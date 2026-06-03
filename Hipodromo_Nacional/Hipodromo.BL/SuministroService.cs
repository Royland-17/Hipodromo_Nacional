using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Npgsql;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class SuministroService
{
    private readonly PostgresContext _ctx;

    public SuministroService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<SuministroListaViewModel>> ObtenerListaAsync()
    {
        return await _ctx.Suministros
            .AsNoTracking()
            .Include(s => s.IdTipoSuministroNavigation)
            .Include(s => s.IdProveedorNavigation)
            .OrderByDescending(s => s.FechaIngreso)
            .ThenBy(s => s.Codigo)
            .Select(s => new SuministroListaViewModel
            {
                IdSuministro = s.IdSuministro,
                Codigo = s.Codigo,
                Tipo = s.IdTipoSuministroNavigation.Descripcion,
                Proveedor = s.IdProveedorNavigation.Nombre,
                CantidadDisponible = s.CantidadDisponible,
                FechaIngreso = s.FechaIngreso,
                Activo = s.Activo ?? true
            })
            .ToListAsync();
    }

    public async Task<SuministroViewModel?> ObtenerParaEditarAsync(int id)
    {
        return await _ctx.Suministros
            .AsNoTracking()
            .Where(s => s.IdSuministro == id)
            .Select(s => new SuministroViewModel
            {
                IdSuministro = s.IdSuministro,
                Codigo = s.Codigo,
                IdTipoSuministro = s.IdTipoSuministro,
                IdProveedor = s.IdProveedor,
                CantidadDisponible = s.CantidadDisponible,
                FechaIngreso = s.FechaIngreso
            })
            .FirstOrDefaultAsync();
    }

    public async Task CargarSelectsAsync(SuministroViewModel vm)
    {
        vm.TiposSuministro = await _ctx.TcTipoSuministros
            .AsNoTracking()
            .OrderBy(t => t.Descripcion)
            .Select(t => new SelectListItem(t.Descripcion, t.IdTipoSuministro.ToString()))
            .ToListAsync();

        vm.Proveedores = await _ctx.Proveedores
            .AsNoTracking()
            .Where(p => p.Activo != false)
            .OrderBy(p => p.Nombre)
            .Select(p => new SelectListItem(p.Nombre, p.IdProveedor.ToString()))
            .ToListAsync();
    }

    public async Task<string> GenerarCodigoAutomaticoAsync()
    {
        for (var intento = 0; intento < 5; intento++)
        {
            var codigo = $"SUM-{DateTime.UtcNow:yyyyMMddHHmmssfff}-{Random.Shared.Next(100, 999)}";

            var existe = await _ctx.Suministros
                .AsNoTracking()
                .AnyAsync(s => s.Codigo == codigo);

            if (!existe)
                return codigo;
        }

        var token = Guid.NewGuid().ToString("N")[..12].ToUpperInvariant();
        return $"SUM-{token}";
    }

    public async Task CrearAsync(SuministroViewModel vm)
    {
        var idUnidadMedida = await _ctx.TcUnidadMedida
            .AsNoTracking()
            .OrderBy(u => u.IdUnidadMedida)
            .Select(u => u.IdUnidadMedida)
            .FirstOrDefaultAsync();

        if (idUnidadMedida <= 0)
            throw new InvalidOperationException("No hay unidad de medida configurada para registrar suministros.");

        async Task EjecutarInsertAsync(string codigo)
        {
            await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
                CALL public.sp_insert_suministro(
                    {codigo},
                    {codigo},
                    {vm.IdTipoSuministro},
                    {vm.IdProveedor},
                    {idUnidadMedida},
                    {vm.CantidadDisponible},
                    {0m}
                )
                """);
        }

        var codigoGenerado = await GenerarCodigoAutomaticoAsync();
        try
        {
            await EjecutarInsertAsync(codigoGenerado);
        }
        catch (Exception ex) when (EsCodigoSuministroDuplicado(ex))
        {
            codigoGenerado = await GenerarCodigoAutomaticoAsync();
            await EjecutarInsertAsync(codigoGenerado);
        }

        vm.Codigo = codigoGenerado;
    }

    private static bool EsCodigoSuministroDuplicado(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "suministros_codigo_key", StringComparison.OrdinalIgnoreCase);
    }

    public async Task EditarAsync(int id, SuministroViewModel vm)
    {
        await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
            CALL public.sp_update_suministro(
                {id},
                {vm.CantidadDisponible},
                {vm.IdProveedor},
                {true}
            )
            """);

        var actualizados = await _ctx.Suministros
            .Where(s => s.IdSuministro == id)
            .ExecuteUpdateAsync(setters => setters
                .SetProperty(s => s.IdTipoSuministro, vm.IdTipoSuministro));

        if (actualizados == 0)
            throw new InvalidOperationException("No se encontró el suministro a editar.");
    }

    public async Task DesactivarAsync(int id)
    {
        await _ctx.Database.ExecuteSqlInterpolatedAsync($"CALL public.sp_delete_suministro({id})");
    }

    public async Task ActivarAsync(int id)
    {
        var actualizados = await _ctx.Suministros
            .Where(s => s.IdSuministro == id)
            .ExecuteUpdateAsync(setters => setters
                .SetProperty(s => s.Activo, true));

        if (actualizados == 0)
            throw new InvalidOperationException("No se encontró el suministro a activar.");
    }
}
