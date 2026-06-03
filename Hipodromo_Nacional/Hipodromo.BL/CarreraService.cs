using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Npgsql;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class CarreraService
{
    private readonly PostgresContext _ctx;

    public CarreraService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<CarreraListaViewModel>> ObtenerListaAsync()
    {
        return await _ctx.Eventos
            .Include(e => e.IdTipoCarreraNavigation)
            .Include(e => e.IdEstadoEventoNavigation)
            .Include(e => e.Inscripciones)
            .OrderByDescending(e => e.FechaEvento)
            .Select(e => new CarreraListaViewModel
            {
                IdEvento = e.IdEvento,
                CodigoEvento = e.CodigoEvento,
                Nombre = e.Nombre,
                FechaEvento = e.FechaEvento,
                DistanciaMetros = e.DistanciaMetros,
                PremioTotal = e.PremioTotal,
                PrecioInscripcion = e.PrecioInscripcion,
                TipoCarrera = e.IdTipoCarreraNavigation.Descripcion,
                Estado = e.IdEstadoEventoNavigation.Descripcion,
                TotalInscritos = e.Inscripciones.Count
            })
            .ToListAsync();
    }

    public async Task<Evento?> ObtenerPorIdAsync(int id)
    {
        return await _ctx.Eventos.FindAsync(id);
    }

    public async Task CargarSelectsAsync(CarreraViewModel vm)
    {
        vm.TiposCarrera = await _ctx.TcTipoCarreras
            .OrderBy(t => t.Descripcion)
            .Select(t => new SelectListItem(t.Descripcion, t.IdTipoCarrera.ToString()))
            .ToListAsync();

        vm.EstadosEvento = await _ctx.TcEstadoEventos
            .OrderBy(e => e.Descripcion)
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoEvento.ToString()))
            .ToListAsync();
    }

    public async Task CrearAsync(CarreraViewModel vm)
    {
        var codigoEvento = await GenerarCodigoEventoAsync();

        var carrera = new Evento
        {
            CodigoEvento = codigoEvento,
            Nombre = vm.Nombre,
            FechaEvento = vm.FechaEvento,
            DistanciaMetros = vm.DistanciaMetros,
            PremioTotal = vm.PremioTotal,
            PrecioInscripcion = vm.PrecioInscripcion,
            ComisionAdmin = vm.ComisionAdmin,
            IdTipoCarrera = vm.IdTipoCarrera,
            IdEstadoEvento = vm.IdEstadoEvento,
            Observaciones = vm.Observaciones
        };

        _ctx.Eventos.Add(carrera);
        try
        {
            await _ctx.SaveChangesAsync();
        }
        catch (DbUpdateException ex) when (EsViolacionPkEventos(ex))
        {
            await SincronizarSecuenciaEventosAsync();

            try
            {
                await _ctx.SaveChangesAsync();
            }
            catch (DbUpdateException retryEx) when (EsViolacionPkEventos(retryEx))
            {
                throw new InvalidOperationException(
                    "No se pudo guardar la carrera porque la secuencia de IDs de eventos esta desincronizada. Intenta nuevamente.",
                    retryEx);
            }
        }
        catch (DbUpdateException ex) when (EsCodigoEventoDuplicado(ex))
        {
            carrera.CodigoEvento = await GenerarCodigoEventoAsync();
            await _ctx.SaveChangesAsync();
        }
    }

    public async Task EditarAsync(int id, CarreraViewModel vm)
    {
        var carrera = await _ctx.Eventos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        carrera.Nombre = vm.Nombre;
        carrera.FechaEvento = vm.FechaEvento;
        carrera.DistanciaMetros = vm.DistanciaMetros;
        carrera.PremioTotal = vm.PremioTotal;
        carrera.PrecioInscripcion = vm.PrecioInscripcion;
        carrera.ComisionAdmin = vm.ComisionAdmin;
        carrera.IdTipoCarrera = vm.IdTipoCarrera;
        carrera.IdEstadoEvento = vm.IdEstadoEvento;
        carrera.Observaciones = vm.Observaciones;

        await _ctx.SaveChangesAsync();
    }

    private async Task<string> GenerarCodigoEventoAsync()
    {
        var prefijo = $"CAR-{DateTime.Now:yyyy}-";

        var codigos = await _ctx.Eventos
            .AsNoTracking()
            .Where(e => e.CodigoEvento.StartsWith(prefijo))
            .Select(e => e.CodigoEvento)
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

    public async Task<CarreraResumenViewModel?> ObtenerResumenAsync(int id)
    {
        return await _ctx.Eventos
            .Include(e => e.IdEstadoEventoNavigation)
            .Where(e => e.IdEvento == id)
            .Select(e => new CarreraResumenViewModel
            {
                IdEvento = e.IdEvento,
                CodigoEvento = e.CodigoEvento,
                Nombre = e.Nombre,
                FechaEvento = e.FechaEvento,
                Estado = e.IdEstadoEventoNavigation.Descripcion
            })
            .FirstOrDefaultAsync();
    }

    public async Task<InscripcionesCarreraViewModel?> ObtenerInscripcionesAsync(int idEvento)
    {
        var carrera = await ObtenerResumenAsync(idEvento);
        if (carrera is null) return null;

        var inscripciones = await _ctx.Inscripciones
            .Include(i => i.IdCaballoNavigation)
            .Include(i => i.IdEstadoInscripcionNavigation)
            .Include(i => i.ResultadosCarrera)
            .Where(i => i.IdEvento == idEvento)
            .OrderBy(i => i.PosicionSalida ?? 999)
            .ThenBy(i => i.IdCaballoNavigation.Nombre)
            .Select(i => new InscripcionCarreraListaViewModel
            {
                IdInscripcion = i.IdInscripcion,
                IdEvento = i.IdEvento,
                Caballo = i.IdCaballoNavigation.Nombre,
                CodigoCaballo = i.IdCaballoNavigation.Codigo,
                FechaInscripcion = i.FechaInscripcion,
                PosicionSalida = i.PosicionSalida,
                Estado = i.IdEstadoInscripcionNavigation.Descripcion,
                Observaciones = i.Observaciones,
                TieneResultado = i.ResultadosCarrera != null
            })
            .ToListAsync();

        return new InscripcionesCarreraViewModel
        {
            Carrera = carrera,
            Inscripciones = inscripciones
        };
    }

    public async Task CargarSelectsInscripcionAsync(InscripcionCarreraViewModel vm)
    {
        vm.Carrera = await ObtenerResumenAsync(vm.IdEvento)
            ?? throw new KeyNotFoundException();

        var caballosInscritos = await _ctx.Inscripciones
            .Where(i => i.IdEvento == vm.IdEvento)
            .Select(i => i.IdCaballo)
            .ToListAsync();

        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true && !caballosInscritos.Contains(c.IdCaballo))
            .OrderBy(c => c.Nombre)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.EstadosInscripcion = await _ctx.TcEstadoInscripcions
            .OrderBy(e => e.Descripcion)
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoInscripcion.ToString()))
            .ToListAsync();
    }

    public async Task CrearInscripcionAsync(InscripcionCarreraViewModel vm)
    {
        var certificacionVigente = await TieneCertificacionVigenteAsync(vm.IdCaballo);
        if (!certificacionVigente)
        {
            throw new InvalidOperationException("El caballo seleccionado no tiene una certificacion veterinaria vigente.");
        }

        var yaInscrito = await _ctx.Inscripciones
            .AnyAsync(i => i.IdEvento == vm.IdEvento && i.IdCaballo == vm.IdCaballo);

        if (yaInscrito)
        {
            throw new InvalidOperationException("Este caballo ya está inscrito en la carrera.");
        }

        await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
            CALL public.sp_insert_inscripcion(
                {vm.IdEvento},
                {vm.IdCaballo},
                {vm.PosicionSalida},
                {vm.IdEstadoInscripcion}
            )
            """);

        if (!string.IsNullOrWhiteSpace(vm.Observaciones))
        {
            var ultimaInscripcion = await _ctx.Inscripciones
                .Where(i => i.IdEvento == vm.IdEvento && i.IdCaballo == vm.IdCaballo)
                .OrderByDescending(i => i.IdInscripcion)
                .FirstOrDefaultAsync();

            if (ultimaInscripcion is not null)
            {
                ultimaInscripcion.Observaciones = vm.Observaciones;
                await _ctx.SaveChangesAsync();
            }
        }
    }

    public async Task<ResultadosCarreraViewModel?> ObtenerResultadosAsync(int idEvento)
    {
        var carrera = await ObtenerResumenAsync(idEvento);
        if (carrera is null) return null;

        var resultados = await _ctx.Inscripciones
            .Include(i => i.IdCaballoNavigation)
            .Include(i => i.ResultadosCarrera)
            .Where(i => i.IdEvento == idEvento)
            .OrderBy(i => i.ResultadosCarrera == null ? 999 : i.ResultadosCarrera.PosicionFinal)
            .ThenBy(i => i.PosicionSalida ?? 999)
            .ThenBy(i => i.IdCaballoNavigation.Nombre)
            .Select(i => new ResultadoCarreraListaViewModel
            {
                IdInscripcion = i.IdInscripcion,
                IdResultado = i.ResultadosCarrera == null ? null : i.ResultadosCarrera.IdResultado,
                Caballo = i.IdCaballoNavigation.Nombre,
                CodigoCaballo = i.IdCaballoNavigation.Codigo,
                PosicionSalida = i.PosicionSalida,
                PosicionFinal = i.ResultadosCarrera == null ? null : i.ResultadosCarrera.PosicionFinal,
                TiempoSegundos = i.ResultadosCarrera == null ? null : i.ResultadosCarrera.TiempoSegundos,
                PremioObtenido = i.ResultadosCarrera == null ? null : i.ResultadosCarrera.PremioObtenido,
                Descalificado = i.ResultadosCarrera != null && i.ResultadosCarrera.Descalificado == true,
                MotivoDescalificacion = i.ResultadosCarrera == null ? null : i.ResultadosCarrera.MotivoDescalificacion
            })
            .ToListAsync();

        return new ResultadosCarreraViewModel
        {
            Carrera = carrera,
            Resultados = resultados
        };
    }

    public async Task<ResultadoCarreraViewModel?> ObtenerResultadoFormAsync(int idInscripcion)
    {
        var inscripcion = await _ctx.Inscripciones
            .Include(i => i.IdEventoNavigation)
                .ThenInclude(e => e.IdEstadoEventoNavigation)
            .Include(i => i.IdCaballoNavigation)
            .Include(i => i.ResultadosCarrera)
            .FirstOrDefaultAsync(i => i.IdInscripcion == idInscripcion);

        if (inscripcion is null) return null;

        return new ResultadoCarreraViewModel
        {
            IdResultado = inscripcion.ResultadosCarrera?.IdResultado ?? 0,
            IdEvento = inscripcion.IdEvento,
            IdInscripcion = inscripcion.IdInscripcion,
            PosicionFinal = inscripcion.ResultadosCarrera?.PosicionFinal ?? 1,
            TiempoSegundos = inscripcion.ResultadosCarrera?.TiempoSegundos,
            PremioObtenido = inscripcion.ResultadosCarrera?.PremioObtenido,
            Descalificado = inscripcion.ResultadosCarrera?.Descalificado == true,
            MotivoDescalificacion = inscripcion.ResultadosCarrera?.MotivoDescalificacion,
            Caballo = inscripcion.IdCaballoNavigation.Nombre,
            CodigoCaballo = inscripcion.IdCaballoNavigation.Codigo,
            Carrera = new CarreraResumenViewModel
            {
                IdEvento = inscripcion.IdEventoNavigation.IdEvento,
                CodigoEvento = inscripcion.IdEventoNavigation.CodigoEvento,
                Nombre = inscripcion.IdEventoNavigation.Nombre,
                FechaEvento = inscripcion.IdEventoNavigation.FechaEvento,
                Estado = inscripcion.IdEventoNavigation.IdEstadoEventoNavigation.Descripcion
            }
        };
    }

    public async Task GuardarResultadoAsync(ResultadoCarreraViewModel vm)
    {
        var resultado = await _ctx.ResultadosCarreras
            .FirstOrDefaultAsync(r => r.IdInscripcion == vm.IdInscripcion);

        if (resultado is null)
        {
            resultado = new ResultadosCarrera
            {
                IdInscripcion = vm.IdInscripcion,
                FechaRegistro = DateTime.Now
            };
            _ctx.ResultadosCarreras.Add(resultado);
        }

        resultado.PosicionFinal = vm.PosicionFinal;
        resultado.TiempoSegundos = vm.TiempoSegundos;
        resultado.PremioObtenido = vm.PremioObtenido ?? 0;
        resultado.Descalificado = vm.Descalificado;
        resultado.MotivoDescalificacion = vm.Descalificado ? vm.MotivoDescalificacion : null;

        await _ctx.SaveChangesAsync();

        await _ctx.Database.ExecuteSqlInterpolatedAsync($"CALL public.sp_calcular_premios({vm.IdEvento})");
    }

    private async Task<bool> TieneCertificacionVigenteAsync(int idCaballo)
    {
        var vigente = await _ctx.Database
            .SqlQueryRaw<bool>($"SELECT public.fn_certificacion_vigente({idCaballo})")
            .FirstOrDefaultAsync();

        return vigente;
    }

    private async Task SincronizarSecuenciaInscripcionesAsync()
    {
        await _ctx.Database.ExecuteSqlRawAsync("""
            SELECT setval(
                COALESCE(pg_get_serial_sequence('public.inscripciones', 'id_inscripcion'), 'public.inscripciones_id_inscripcion_seq'),
                COALESCE((SELECT MAX(id_inscripcion) FROM public.inscripciones), 0) + 1,
                false
            );
            """);
    }

    private async Task SincronizarSecuenciaEventosAsync()
    {
        await _ctx.Database.ExecuteSqlRawAsync("""
            SELECT setval(
                COALESCE(pg_get_serial_sequence('public.eventos', 'id_evento'), 'public.eventos_id_evento_seq'),
                COALESCE((SELECT MAX(id_evento) FROM public.eventos), 0) + 1,
                false
            );
            """);
    }

    private static bool EsViolacionPkInscripciones(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "inscripciones_pkey", StringComparison.OrdinalIgnoreCase);
    }

    private static bool EsViolacionPkEventos(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "eventos_pkey", StringComparison.OrdinalIgnoreCase);
    }

    private static bool EsCodigoEventoDuplicado(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "eventos_codigo_evento_key", StringComparison.OrdinalIgnoreCase);
    }
}
