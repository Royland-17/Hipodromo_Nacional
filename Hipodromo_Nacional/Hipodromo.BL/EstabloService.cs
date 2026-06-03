using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Npgsql;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class EstabloService
{
    private readonly PostgresContext _ctx;

    public EstabloService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<EstabloViewModel>> ObtenerListaAsync()
    {
        var establos = await _ctx.Establos
            .Include(e => e.IdEstadoEstabloNavigation)
            .Include(e => e.AsignacionesEstablos)
            .ToListAsync();

        return establos.Select(e => new EstabloViewModel
        {
            IdEstablo = e.IdEstablo,
            Codigo = e.Codigo,
            Nombre = e.Nombre,
            Ubicacion = e.Ubicacion,
            Capacidad = e.Capacidad,
            IdEstadoEstablo = e.IdEstadoEstablo,
            CaballosAsignados = e.AsignacionesEstablos.Count(a => a.Activa == true)
        }).ToList();
    }

    public async Task<Establo?> ObtenerPorIdAsync(int id)
    {
        return await _ctx.Establos
            .Include(e => e.IdEstadoEstabloNavigation)
            .FirstOrDefaultAsync(e => e.IdEstablo == id);
    }

    public async Task CargarSelectsAsync(EstabloViewModel vm)
    {
        vm.EstadosEstablo = await _ctx.TcEstadoEstablos
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoEstablo.ToString()))
            .ToListAsync();
    }

    public async Task CrearAsync(EstabloViewModel vm)
    {
        var codigo = await GenerarCodigoAutomaticoAsync();

        var establo = new Establo
        {
            Codigo = codigo,
            Nombre = vm.Nombre,
            Ubicacion = vm.Ubicacion,
            Capacidad = vm.Capacidad,
            IdEstadoEstablo = vm.IdEstadoEstablo
        };

        _ctx.Establos.Add(establo);

        try
        {
            await _ctx.SaveChangesAsync();
        }
        catch (DbUpdateException ex) when (EsCodigoEstabloDuplicado(ex))
        {
            establo.Codigo = await GenerarCodigoAutomaticoAsync();
            await _ctx.SaveChangesAsync();
        }
    }

    public async Task EditarAsync(int id, EstabloViewModel vm)
    {
        var establo = await _ctx.Establos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        establo.Nombre = vm.Nombre;
        establo.Ubicacion = vm.Ubicacion;
        establo.Capacidad = vm.Capacidad;
        establo.IdEstadoEstablo = vm.IdEstadoEstablo;

        await _ctx.SaveChangesAsync();
    }

    private async Task<string> GenerarCodigoAutomaticoAsync()
    {
        var prefijo = $"EST-{DateTime.Now:yyyy}-";

        var codigos = await _ctx.Establos
            .AsNoTracking()
            .Where(e => e.Codigo.StartsWith(prefijo))
            .Select(e => e.Codigo)
            .ToListAsync();

        var maxConsecutivo = 0;
        foreach (var codigo in codigos)
        {
            if (string.IsNullOrWhiteSpace(codigo) || codigo.Length <= prefijo.Length)
                continue;

            var sufijo = codigo[prefijo.Length..];
            if (int.TryParse(sufijo, out var consecutivo) && consecutivo > maxConsecutivo)
                maxConsecutivo = consecutivo;
        }

        return $"{prefijo}{(maxConsecutivo + 1):D6}";
    }

    private static bool EsCodigoEstabloDuplicado(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "establos_codigo_key", StringComparison.OrdinalIgnoreCase);
    }

    // ── Asignaciones ──────────────────────────────────────────────────────

    public async Task<string?> ObtenerNombreEstabloAsync(int id) =>
        await _ctx.Establos.Where(e => e.IdEstablo == id).Select(e => e.Nombre).FirstOrDefaultAsync();

    public async Task<List<AsignacionViewModel>> ObtenerAsignacionesAsync(int? idEstablo = null)
    {
        return await _ctx.AsignacionesEstablos
            .Include(a => a.IdCaballoNavigation)
            .Include(a => a.IdEstabloNavigation)
            .Where(a => a.Activa == true && (idEstablo == null || a.IdEstablo == idEstablo))
            .Select(a => new AsignacionViewModel
            {
                IdAsignacion = a.IdAsignacion,
                IdCaballo = a.IdCaballo,
                IdEstablo = a.IdEstablo,
                FechaIngreso = a.FechaIngreso,
                FechaSalida = a.FechaSalida,
                Observaciones = a.Observaciones,
                Activa = a.Activa ?? true,
                NombreCaballo = a.IdCaballoNavigation.Nombre,
                NombreEstablo = a.IdEstabloNavigation.Nombre
            })
            .ToListAsync();
    }

    public async Task CargarSelectsAsignacionAsync(AsignacionViewModel vm)
    {
        var asignadosIds = await _ctx.AsignacionesEstablos
            .Where(a => a.Activa == true)
            .Select(a => a.IdCaballo)
            .ToListAsync();

        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true && !asignadosIds.Contains(c.IdCaballo))
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Establos = await _ctx.Establos
            .Select(e => new SelectListItem(e.Nombre + " - " + e.Ubicacion, e.IdEstablo.ToString()))
            .ToListAsync();
    }

    public async Task CrearAsignacionAsync(AsignacionViewModel vm)
    {
        var asignacion = new AsignacionesEstablo
        {
            IdCaballo = vm.IdCaballo,
            IdEstablo = vm.IdEstablo,
            FechaIngreso = vm.FechaIngreso,
            FechaSalida = vm.FechaSalida,
            Observaciones = vm.Observaciones,
            Activa = true
        };
        _ctx.AsignacionesEstablos.Add(asignacion);
        await _ctx.SaveChangesAsync();
    }

    public async Task DesasignarAsync(int id)
    {
        var asignacion = await _ctx.AsignacionesEstablos.FindAsync(id)
            ?? throw new KeyNotFoundException();
        asignacion.Activa = false;
        asignacion.FechaSalida = DateOnly.FromDateTime(DateTime.Today);
        await _ctx.SaveChangesAsync();
    }
}
