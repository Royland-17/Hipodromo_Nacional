using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Npgsql;
using NpgsqlTypes;
using System.Text;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class AlimentacionService
{
    private readonly PostgresContext _ctx;

    public AlimentacionService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<AlimentacionListaViewModel>> ObtenerListaAsync(
        AlimentacionFiltroViewModel? filtro = null,
        CancellationToken cancellationToken = default)
    {
        var idCaballo = filtro?.IdCaballo is > 0 ? filtro.IdCaballo : null;
        var idTipoSuministro = filtro?.IdTipoSuministro is > 0 ? filtro.IdTipoSuministro : null;
        var fechaDesde = filtro?.FechaDesde is not null
            ? NormalizarTimestampSinZona(filtro.FechaDesde.Value.ToDateTime(TimeOnly.MinValue))
            : (DateTime?)null;
        var fechaHasta = filtro?.FechaHasta is not null
            ? NormalizarTimestampSinZona(filtro.FechaHasta.Value.ToDateTime(TimeOnly.MaxValue))
            : (DateTime?)null;

        var previousTimeout = _ctx.Database.GetCommandTimeout();
        try
        {
            _ctx.Database.SetCommandTimeout(5);
            var sql = new StringBuilder(
                """
                SELECT a.id_alimentacion AS "IdAlimentacion",
                       c.nombre AS "Caballo",
                       t.descripcion AS "TipoAlimento",
                       s.nombre AS "Alimento",
                       a.fecha_alimentacion AS "Fecha",
                       a.cantidad AS "Cantidad"
                FROM (
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_default
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q1_2025
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q2_2025
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q3_2025
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q4_2025
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q1_2026
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q2_2026
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q3_2026
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q4_2026
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q1_2027
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q2_2027
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q3_2027
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q4_2027
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q1_2028
                    UNION ALL
                    SELECT id_alimentacion, fecha_alimentacion, cantidad, id_caballo, id_suministro, activo FROM ali_q2_2028
                ) AS a
                INNER JOIN caballos AS c ON a.id_caballo = c.id_caballo
                INNER JOIN suministros AS s ON a.id_suministro = s.id_suministro
                INNER JOIN tc_tipo_suministro AS t ON s.id_tipo_suministro = t.id_tipo_suministro
                WHERE (a.activo <> FALSE OR a.activo IS NULL)
                """);

            var parameters = new List<object>();

            if (idCaballo.HasValue)
            {
                sql.AppendLine("  AND a.id_caballo = @p_id_caballo");
                parameters.Add(new NpgsqlParameter("p_id_caballo", NpgsqlDbType.Integer) { Value = idCaballo.Value });
            }

            if (idTipoSuministro.HasValue)
            {
                sql.AppendLine("  AND s.id_tipo_suministro = @p_id_tipo_suministro");
                parameters.Add(new NpgsqlParameter("p_id_tipo_suministro", NpgsqlDbType.Integer) { Value = idTipoSuministro.Value });
            }

            if (fechaDesde.HasValue)
            {
                sql.AppendLine("  AND a.fecha_alimentacion >= @p_fecha_desde");
                parameters.Add(new NpgsqlParameter("p_fecha_desde", NpgsqlDbType.Timestamp) { Value = fechaDesde.Value });
            }

            if (fechaHasta.HasValue)
            {
                sql.AppendLine("  AND a.fecha_alimentacion <= @p_fecha_hasta");
                parameters.Add(new NpgsqlParameter("p_fecha_hasta", NpgsqlDbType.Timestamp) { Value = fechaHasta.Value });
            }

            sql.AppendLine("ORDER BY a.fecha_alimentacion DESC");
            sql.AppendLine("LIMIT 500");

            return await _ctx.Database.SqlQueryRaw<AlimentacionListaViewModel>(sql.ToString(), parameters.ToArray())
                .ToListAsync(cancellationToken);
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
        var fechaAlimentacion = NormalizarTimestampSinZona(vm.FechaAlimentacion);

        var idUsuarioRegistro = await _ctx.Usuarios
            .AsNoTracking()
            .Where(u => u.Activo != false)
            .OrderBy(u => u.IdUsuario)
            .Select(u => u.IdUsuario)
            .FirstOrDefaultAsync();

        if (idUsuarioRegistro <= 0)
            throw new InvalidOperationException("No existe un usuario activo para registrar la alimentacion.");

        var pIdCaballo = new NpgsqlParameter("p_id_caballo", vm.IdCaballo);
        var pIdSuministro = new NpgsqlParameter("p_id_suministro", vm.IdSuministro);
        var pIdUsuario = new NpgsqlParameter("p_id_usuario", idUsuarioRegistro);
        var pFecha = new NpgsqlParameter("p_fecha_alimentacion", NpgsqlDbType.Timestamp)
        {
            Value = fechaAlimentacion
        };
        var pCantidad = new NpgsqlParameter("p_cantidad", vm.Cantidad);
        var pObs = new NpgsqlParameter("p_observaciones", (object?)vm.Observaciones ?? DBNull.Value);

        await _ctx.Database.ExecuteSqlRawAsync(
            "CALL public.sp_insert_alimentacion(@p_id_caballo, @p_id_suministro, @p_id_usuario, @p_fecha_alimentacion, @p_cantidad, @p_observaciones)",
            pIdCaballo,
            pIdSuministro,
            pIdUsuario,
            pFecha,
            pCantidad,
            pObs);
    }

    private static DateTime NormalizarTimestampSinZona(DateTime fecha)
    {
        return fecha.Kind == DateTimeKind.Unspecified
            ? fecha
            : DateTime.SpecifyKind(fecha, DateTimeKind.Unspecified);
    }
}
