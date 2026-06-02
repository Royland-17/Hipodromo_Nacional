using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class AlimentacionService
{
    private readonly PostgresContext _ctx;

    public AlimentacionService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<AlimentacionListaViewModel>> ObtenerListaAsync(
        AlimentacionFiltroViewModel? filtro = null,
        CancellationToken cancellationToken = default)
    {
        var query = _ctx.AliDefaults
            .AsNoTracking()
            .Where(a => a.Activo != false)
            .AsQueryable();

        if (filtro?.IdCaballo is > 0)
            query = query.Where(a => a.IdCaballo == filtro.IdCaballo.Value);

        if (filtro?.IdTipoSuministro is > 0)
            query = query.Where(a => a.IdSuministroNavigation.IdTipoSuministro == filtro.IdTipoSuministro.Value);

        if (filtro?.FechaDesde is not null)
        {
            var desde = filtro.FechaDesde.Value.ToDateTime(TimeOnly.MinValue);
            query = query.Where(a => a.FechaAlimentacion >= desde);
        }

        if (filtro?.FechaHasta is not null)
        {
            var hasta = filtro.FechaHasta.Value.ToDateTime(TimeOnly.MaxValue);
            query = query.Where(a => a.FechaAlimentacion <= hasta);
        }

        var previousTimeout = _ctx.Database.GetCommandTimeout();
        try
        {
            _ctx.Database.SetCommandTimeout(5);
            return await query
                .OrderByDescending(a => a.FechaAlimentacion)
                .Take(500)
                .Select(a => new AlimentacionListaViewModel
                {
                    IdAlimentacion = a.IdAlimentacion,
                    Caballo = a.IdCaballoNavigation.Nombre,
                    TipoAlimento = a.IdSuministroNavigation.IdTipoSuministroNavigation.Descripcion,
                    Alimento = a.IdSuministroNavigation.Nombre,
                    Fecha = a.FechaAlimentacion,
                    Cantidad = a.Cantidad
                })
                .ToListAsync(cancellationToken);
        }
        catch
        {
            return [];
        }
        finally
        {
            _ctx.Database.SetCommandTimeout(previousTimeout);
        }
    }

    public async Task CargarFiltrosAsync(AlimentacionFiltroViewModel vm, CancellationToken cancellationToken = default)
    {
        var previousTimeout = _ctx.Database.GetCommandTimeout();
        try
        {
            _ctx.Database.SetCommandTimeout(5);
            vm.Caballos = await _ctx.Caballos
                .AsNoTracking()
                .Where(c => c.Activo == true)
                .OrderBy(c => c.Nombre)
                .Select(c => new SelectListItem($"{c.Nombre} ({c.Codigo})", c.IdCaballo.ToString()))
                .ToListAsync(cancellationToken);
        }
        catch
        {
            vm.Caballos = [];
        }
        finally
        {
            _ctx.Database.SetCommandTimeout(previousTimeout);
        }

        // Se deja vacio temporalmente para evitar timeout recurrente en esta pantalla.
        vm.TiposAlimento = [];
    }

    public async Task CargarSelectsAsync(AlimentacionViewModel vm, CancellationToken cancellationToken = default)
    {
        var previousTimeout = _ctx.Database.GetCommandTimeout();
        try
        {
            _ctx.Database.SetCommandTimeout(5);
            vm.Caballos = await _ctx.Caballos
                .AsNoTracking()
                .Where(c => c.Activo == true)
                .OrderBy(c => c.Nombre)
                .Select(c => new SelectListItem($"{c.Nombre} ({c.Codigo})", c.IdCaballo.ToString()))
                .ToListAsync(cancellationToken);
        }
        catch
        {
            vm.Caballos = [];
        }
        finally
        {
            _ctx.Database.SetCommandTimeout(previousTimeout);
        }

        previousTimeout = _ctx.Database.GetCommandTimeout();
        try
        {
            _ctx.Database.SetCommandTimeout(5);
            vm.TiposAlimento = await _ctx.TcTipoSuministros
                .AsNoTracking()
                .OrderBy(t => t.Descripcion)
                .Select(t => new SelectListItem(t.Descripcion, t.IdTipoSuministro.ToString()))
                .ToListAsync(cancellationToken);
        }
        catch
        {
            vm.TiposAlimento = [];
        }
        finally
        {
            _ctx.Database.SetCommandTimeout(previousTimeout);
        }

        vm.Alimentos = vm.IdTipoSuministro > 0
            ? await ObtenerSuministrosPorTipoAsync(vm.IdTipoSuministro)
            : [];
    }

    public async Task<List<SelectListItem>> ObtenerSuministrosPorTipoAsync(int idTipoSuministro)
    {
        if (idTipoSuministro <= 0) return [];

        return await _ctx.Suministros
            .AsNoTracking()
            .Where(s => s.Activo != false && s.IdTipoSuministro == idTipoSuministro)
            .OrderBy(s => s.Nombre)
            .Select(s => new SelectListItem(s.Nombre + " [" + s.Codigo + "]", s.IdSuministro.ToString()))
            .ToListAsync();
    }

    public async Task RegistrarAsync(AlimentacionViewModel vm)
    {
        var idUsuarioRegistro = await _ctx.Usuarios
            .AsNoTracking()
            .Where(u => u.Activo != false)
            .OrderBy(u => u.IdUsuario)
            .Select(u => u.IdUsuario)
            .FirstOrDefaultAsync();

        if (idUsuarioRegistro <= 0)
            throw new InvalidOperationException("No existe un usuario activo para registrar la alimentacion.");

        await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
            CALL public.sp_insert_alimentacion(
                {vm.IdCaballo},
                {vm.IdSuministro},
                {idUsuarioRegistro},
                {vm.FechaAlimentacion},
                {vm.Cantidad},
                {vm.Observaciones}
            )
            """);
    }
}
