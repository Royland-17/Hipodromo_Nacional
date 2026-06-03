using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;
using Npgsql;
using NpgsqlTypes;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador + "," + AppRoles.Veterinario)]
public class HistorialVetController : Controller
{
    private readonly PostgresContext _ctx;

    public HistorialVetController(PostgresContext ctx) => _ctx = ctx;

    public async Task<IActionResult> Index()
    {
        var historial = await _ctx.Database
            .SqlQueryRaw<HistorialVetResultado>(@"
                SELECT
                    hv.id_historial AS IdHistorial,
                    hv.id_caballo AS IdCaballo,
                    hv.id_veterinario AS IdVeterinario,
                    hv.id_certificacion AS IdCertificacion,
                    hv.fecha_revision AS FechaRevision,
                    hv.diagnostico AS Diagnostico,
                    hv.tratamiento AS Tratamiento,
                    hv.observaciones AS Observaciones,
                    hv.proximo_control AS ProximoControl,
                    c.nombre AS NombreCaballo,
                    u.nombre || ' ' || u.apellido1 AS NombreVeterinario
                FROM historial_veterinario hv
                JOIN caballos c ON c.id_caballo = hv.id_caballo
                JOIN veterinarios v ON v.id_veterinario = hv.id_veterinario
                JOIN usuarios u ON u.id_usuario = v.id_usuario
                ORDER BY hv.fecha_revision DESC")
            .ToListAsync();

        return View(historial);
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new HistorialVetViewModel();
            var veterinarioActual = await ObtenerVeterinarioActualAsync();
            if (veterinarioActual is null)
            {
                TempData["Error"] = "Tu usuario no tiene un perfil de veterinario asociado para registrar revisiones.";
                return RedirectToAction(nameof(Index));
            }

            vm.IdVeterinario = veterinarioActual.Value.IdVeterinario;
            vm.NombreVeterinario = veterinarioActual.Value.Nombre;
            await CargarSelectsAsync(vm, veterinarioActual.Value.IdVeterinario, veterinarioActual.Value.Nombre);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(HistorialVetViewModel vm)
    {
        var veterinarioActual = await ObtenerVeterinarioActualAsync();
        if (veterinarioActual is null)
        {
            TempData["Error"] = "Tu usuario no tiene un perfil de veterinario asociado para registrar revisiones.";
            return RedirectToAction(nameof(Index));
        }

        vm.IdVeterinario = veterinarioActual.Value.IdVeterinario;
        vm.NombreVeterinario = veterinarioActual.Value.Nombre;

        if (vm.IdCertificacion.HasValue)
        {
            var certificacionValida = await _ctx.CertificacionesSanitarias
                .AsNoTracking()
                .AnyAsync(c => c.IdCertificacion == vm.IdCertificacion.Value && c.IdCaballo == vm.IdCaballo);

            if (!certificacionValida)
            {
                ModelState.AddModelError(nameof(vm.IdCertificacion), "La certificacion seleccionada no corresponde al caballo elegido.");
            }
        }

        if (!ModelState.IsValid)
        {
            await CargarSelectsAsync(vm, veterinarioActual.Value.IdVeterinario, veterinarioActual.Value.Nombre);
            return View(vm);
        }

        try
        {
            var fechaRevision = vm.FechaRevision.Kind == DateTimeKind.Unspecified
                ? vm.FechaRevision
                : DateTime.SpecifyKind(vm.FechaRevision, DateTimeKind.Unspecified);

            var pIdCaballo = new NpgsqlParameter("p_id_caballo", vm.IdCaballo);
            var pIdVeterinario = new NpgsqlParameter("p_id_veterinario", vm.IdVeterinario);
            var pIdCertificacion = new NpgsqlParameter("p_id_certificacion", vm.IdCertificacion.HasValue ? vm.IdCertificacion.Value : DBNull.Value);
            var pFechaRevision = new NpgsqlParameter("p_fecha_revision", NpgsqlDbType.Timestamp)
            {
                Value = fechaRevision
            };
            var pDiagnostico = new NpgsqlParameter("p_diagnostico", vm.Diagnostico);
            var pTratamiento = new NpgsqlParameter("p_tratamiento", (object?)vm.Tratamiento ?? DBNull.Value);
            var pObservaciones = new NpgsqlParameter("p_observaciones", (object?)vm.Observaciones ?? DBNull.Value);
            var pProximoControl = new NpgsqlParameter("p_proximo_control", NpgsqlDbType.Date)
            {
                Value = vm.ProximoControl.HasValue
                    ? vm.ProximoControl.Value.ToDateTime(TimeOnly.MinValue)
                    : DBNull.Value
            };

            await _ctx.Database.ExecuteSqlRawAsync(
                "CALL public.sp_insert_historial_vet(@p_id_caballo, @p_id_veterinario, @p_id_certificacion, @p_fecha_revision, @p_diagnostico, @p_tratamiento, @p_observaciones, @p_proximo_control)",
                pIdCaballo,
                pIdVeterinario,
                pIdCertificacion,
                pFechaRevision,
                pDiagnostico,
                pTratamiento,
                pObservaciones,
                pProximoControl);
        }
        catch (PostgresException ex) when (ex.SqlState == "42883")
        {
            ModelState.AddModelError(string.Empty, "No se pudo registrar la revision por una incompatibilidad de firma en el procedimiento almacenado.");
            await CargarSelectsAsync(vm, veterinarioActual.Value.IdVeterinario, veterinarioActual.Value.Nombre);
            return View(vm);
        }

        TempData["Exito"] = "Registro veterinario guardado exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> CertificacionesPorCaballo(int idCaballo)
    {
        if (idCaballo <= 0)
            return Json(Array.Empty<object>());

        var certificaciones = await _ctx.CertificacionesSanitarias
            .AsNoTracking()
            .Where(c => c.IdCaballo == idCaballo)
            .OrderByDescending(c => c.FechaEmision)
            .Select(c => new
            {
                id = c.IdCertificacion,
                numero = c.NumeroCertificado
            })
            .ToListAsync();

        return Json(certificaciones);
    }

    public async Task<IActionResult> Certificaciones()
    {
        try { await _ctx.Database.CanConnectAsync(); } catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<CertificacionViewModel>()); }
        var certs = await _ctx.CertificacionesSanitarias
            .Include(c => c.IdCaballoNavigation)
            .Include(c => c.IdVeterinarioNavigation)
                .ThenInclude(v => v.IdUsuarioNavigation)
            .Include(c => c.IdEstadoCertificacionNavigation)
            .OrderByDescending(c => c.FechaEmision)
            .Select(c => new CertificacionViewModel
            {
                IdCertificacion = c.IdCertificacion,
                IdCaballo = c.IdCaballo,
                IdVeterinario = c.IdVeterinario,
                FechaEmision = c.FechaEmision,
                FechaVencimiento = c.FechaVencimiento,
                NumeroCertificado = c.NumeroCertificado,
                Observaciones = c.Observaciones,
                NombreCaballo = c.IdCaballoNavigation.Nombre,
                NombreVeterinario = c.IdVeterinarioNavigation.IdUsuarioNavigation.Nombre
                    + " " + c.IdVeterinarioNavigation.IdUsuarioNavigation.Apellido1,
                EstadoCertificacion = c.IdEstadoCertificacionNavigation.Descripcion
            })
            .ToListAsync();

        return View(certs);
    }

    public async Task<IActionResult> CrearCertificacion()
    {
        try
        {
            var vm = new CertificacionViewModel();
            var veterinarioActual = await ObtenerVeterinarioActualAsync();
            if (veterinarioActual is null)
            {
                TempData["Error"] = "Tu usuario no tiene un perfil de veterinario asociado para emitir certificaciones.";
                return RedirectToAction(nameof(Certificaciones));
            }

            vm.IdVeterinario = veterinarioActual.Value.IdVeterinario;
            vm.NombreVeterinario = veterinarioActual.Value.Nombre;
            vm.NumeroCertificado = await GenerarNumeroCertificadoAutomaticoAsync();
            await CargarSelectsCertAsync(vm, veterinarioActual.Value.IdVeterinario, veterinarioActual.Value.Nombre);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Certificaciones)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CrearCertificacion(CertificacionViewModel vm)
    {
        var veterinarioActual = await ObtenerVeterinarioActualAsync();
        if (veterinarioActual is null)
        {
            TempData["Error"] = "Tu usuario no tiene un perfil de veterinario asociado para emitir certificaciones.";
            return RedirectToAction(nameof(Certificaciones));
        }

        vm.IdVeterinario = veterinarioActual.Value.IdVeterinario;
        vm.NombreVeterinario = veterinarioActual.Value.Nombre;
        vm.NumeroCertificado = await GenerarNumeroCertificadoAutomaticoAsync();

        if (!ModelState.IsValid)
        {
            await CargarSelectsCertAsync(vm, veterinarioActual.Value.IdVeterinario, veterinarioActual.Value.Nombre);
            return View(vm);
        }

        async Task EjecutarInsertCertificacionAsync()
        {
            await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
                CALL public.sp_insert_certificacion(
                    {vm.IdCaballo},
                    {vm.IdVeterinario},
                    {vm.IdEstadoCertificacion},
                    {vm.FechaEmision},
                    {vm.FechaVencimiento},
                    {vm.NumeroCertificado},
                    {vm.Observaciones}
                )
                """);
        }

        try
        {
            await EjecutarInsertCertificacionAsync();
        }
        catch (DbUpdateException ex) when (EsNumeroCertificadoDuplicado(ex))
        {
            vm.NumeroCertificado = await GenerarNumeroCertificadoAutomaticoAsync();
            await EjecutarInsertCertificacionAsync();
        }
        catch (DbUpdateException ex) when (EsViolacionPkCertificacion(ex))
        {
            await _ctx.Database.ExecuteSqlRawAsync("""
                SELECT setval(
                    COALESCE(pg_get_serial_sequence('public.certificaciones_sanitarias', 'id_certificacion'), 'public.certificaciones_sanitarias_id_certificacion_seq'),
                    COALESCE((SELECT MAX(id_certificacion) FROM public.certificaciones_sanitarias), 0) + 1,
                    false
                );
                """);

            await EjecutarInsertCertificacionAsync();
        }

        TempData["Exito"] = "Certificación sanitaria registrada exitosamente.";
        return RedirectToAction(nameof(Certificaciones));
    }

    private async Task CargarSelectsAsync(HistorialVetViewModel vm, int idVeterinarioActual, string nombreVeterinarioActual)
    {
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Veterinarios = [new SelectListItem(nombreVeterinarioActual, idVeterinarioActual.ToString())];

        vm.Certificaciones = vm.IdCaballo > 0
            ? await _ctx.CertificacionesSanitarias
                .Where(c => c.IdCaballo == vm.IdCaballo)
                .OrderByDescending(c => c.FechaEmision)
                .Select(c => new SelectListItem(c.NumeroCertificado, c.IdCertificacion.ToString()))
                .ToListAsync()
            : [];
    }

    private async Task CargarSelectsCertAsync(CertificacionViewModel vm, int idVeterinarioActual, string nombreVeterinarioActual)
    {
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Veterinarios = [new SelectListItem(nombreVeterinarioActual, idVeterinarioActual.ToString())];

        vm.EstadosCertificacion = await _ctx.TcEstadoCertificacions
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoCertificacion.ToString()))
            .ToListAsync();
    }

    private async Task<(int IdVeterinario, string Nombre)?> ObtenerVeterinarioActualAsync()
    {
        var usuarioLogin = User.Identity?.Name;
        if (string.IsNullOrWhiteSpace(usuarioLogin))
            return null;

        var data = await _ctx.Usuarios
            .Where(u => u.Usuario1 == usuarioLogin)
            .Select(u => new
            {
                IdVeterinario = u.Veterinario != null ? (int?)u.Veterinario.IdVeterinario : null,
                Nombre = (u.Nombre + " " + u.Apellido1 + (u.Apellido2 != null ? " " + u.Apellido2 : "")).Trim()
            })
            .FirstOrDefaultAsync();

        if (data?.IdVeterinario is null)
            return null;

        return (data.IdVeterinario.Value, data.Nombre);
    }

    private static bool EsViolacionPkCertificacion(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "certificaciones_sanitarias_pkey", StringComparison.OrdinalIgnoreCase);
    }

    private static bool EsNumeroCertificadoDuplicado(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "certificaciones_sanitarias_numero_certificado_key", StringComparison.OrdinalIgnoreCase);
    }

    private async Task<string> GenerarNumeroCertificadoAutomaticoAsync()
    {
        for (var intento = 0; intento < 5; intento++)
        {
            var numero = $"CERT-{DateTime.UtcNow:yyyyMMddHHmmssfff}-{Random.Shared.Next(100, 999)}";

            var existe = await _ctx.CertificacionesSanitarias
                .AsNoTracking()
                .AnyAsync(c => c.NumeroCertificado == numero);

            if (!existe)
                return numero;
        }

        var token = Guid.NewGuid().ToString("N")[..12].ToUpperInvariant();
        return $"CERT-{token}";
    }
}
