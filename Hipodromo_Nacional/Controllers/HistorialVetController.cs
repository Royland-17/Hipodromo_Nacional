using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

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
            await CargarSelectsAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(HistorialVetViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await CargarSelectsAsync(vm);
            return View(vm);
        }

        await _ctx.Database.ExecuteSqlRawAsync(@"
            INSERT INTO historial_veterinario
                (id_caballo, id_veterinario, id_certificacion, fecha_revision, diagnostico, tratamiento, observaciones, proximo_control)
            VALUES
                ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})",
            vm.IdCaballo,
            vm.IdVeterinario,
            (object?)vm.IdCertificacion ?? DBNull.Value,
            DateTime.SpecifyKind(vm.FechaRevision, DateTimeKind.Utc),
            vm.Diagnostico,
            (object?)vm.Tratamiento ?? DBNull.Value,
            (object?)vm.Observaciones ?? DBNull.Value,
            (object?)vm.ProximoControl ?? DBNull.Value
        );

        TempData["Exito"] = "Registro veterinario guardado exitosamente.";
        return RedirectToAction(nameof(Index));
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
            await CargarSelectsCertAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Certificaciones)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CrearCertificacion(CertificacionViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await CargarSelectsCertAsync(vm);
            return View(vm);
        }

        var cert = new CertificacionesSanitaria
        {
            IdCaballo = vm.IdCaballo,
            IdVeterinario = vm.IdVeterinario,
            IdEstadoCertificacion = vm.IdEstadoCertificacion,
            FechaEmision = vm.FechaEmision,
            FechaVencimiento = vm.FechaVencimiento,
            NumeroCertificado = vm.NumeroCertificado,
            Observaciones = vm.Observaciones
        };
        _ctx.CertificacionesSanitarias.Add(cert);
        await _ctx.SaveChangesAsync();

        TempData["Exito"] = "Certificación sanitaria registrada exitosamente.";
        return RedirectToAction(nameof(Certificaciones));
    }

    private async Task CargarSelectsAsync(HistorialVetViewModel vm)
    {
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Veterinarios = await _ctx.Veterinarios
            .Include(v => v.IdUsuarioNavigation)
            .Select(v => new SelectListItem(
                v.IdUsuarioNavigation.Nombre + " " + v.IdUsuarioNavigation.Apellido1,
                v.IdVeterinario.ToString()))
            .ToListAsync();

        vm.Certificaciones = await _ctx.CertificacionesSanitarias
            .Select(c => new SelectListItem(c.NumeroCertificado, c.IdCertificacion.ToString()))
            .ToListAsync();
    }

    private async Task CargarSelectsCertAsync(CertificacionViewModel vm)
    {
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Veterinarios = await _ctx.Veterinarios
            .Include(v => v.IdUsuarioNavigation)
            .Select(v => new SelectListItem(
                v.IdUsuarioNavigation.Nombre + " " + v.IdUsuarioNavigation.Apellido1,
                v.IdVeterinario.ToString()))
            .ToListAsync();

        vm.EstadosCertificacion = await _ctx.TcEstadoCertificacions
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoCertificacion.ToString()))
            .ToListAsync();
    }
}
