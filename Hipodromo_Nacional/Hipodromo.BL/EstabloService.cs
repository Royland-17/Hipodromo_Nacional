using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

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
        var establo = new Establo
        {
            Codigo = vm.Codigo,
            Nombre = vm.Nombre,
            Ubicacion = vm.Ubicacion,
            Capacidad = vm.Capacidad,
            IdEstadoEstablo = vm.IdEstadoEstablo
        };
        _ctx.Establos.Add(establo);
        await _ctx.SaveChangesAsync();
    }

    public async Task EditarAsync(int id, EstabloViewModel vm)
    {
        var establo = await _ctx.Establos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        establo.Codigo = vm.Codigo;
        establo.Nombre = vm.Nombre;
        establo.Ubicacion = vm.Ubicacion;
        establo.Capacidad = vm.Capacidad;
        establo.IdEstadoEstablo = vm.IdEstadoEstablo;

        await _ctx.SaveChangesAsync();
    }

    // ── Asignaciones ──────────────────────────────────────────────────────

    public async Task<List<AsignacionViewModel>> ObtenerAsignacionesAsync()
    {
        return await _ctx.AsignacionesEstablos
            .Include(a => a.IdCaballoNavigation)
            .Include(a => a.IdEstabloNavigation)
            .Where(a => a.Activa == true)
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
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
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
