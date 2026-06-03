using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class InscripcionesEventoService
{
    private readonly PostgresContext _ctx;

    public InscripcionesEventoService(PostgresContext ctx) => _ctx = ctx;

    public async Task<InscripcionesEventoPageViewModel> ObtenerPantallaAsync(string usuarioLogin, CancellationToken cancellationToken = default)
    {
        var idPropietario = await ObtenerIdPropietarioAsync(usuarioLogin, cancellationToken);
        if (idPropietario is null)
        {
            return new InscripcionesEventoPageViewModel();
        }

        var caballos = await _ctx.Caballos
            .AsNoTracking()
            .Where(c => c.IdPropietario == idPropietario && c.Activo == true)
            .OrderBy(c => c.Nombre)
            .Select(c => new CaballoPropietarioOptionViewModel
            {
                IdCaballo = c.IdCaballo,
                Codigo = c.Codigo,
                Nombre = c.Nombre
            })
            .ToListAsync(cancellationToken);

        var eventosDisponibles = await _ctx.Eventos
            .AsNoTracking()
            .Include(e => e.IdEstadoEventoNavigation)
            .Include(e => e.Inscripciones)
            .Where(e => e.FechaEvento.Date >= DateTime.Today)
            .Where(e =>
                !EF.Functions.ILike(e.IdEstadoEventoNavigation.Descripcion, "%cancel%")
                && !EF.Functions.ILike(e.IdEstadoEventoNavigation.Descripcion, "%final%")
                && !EF.Functions.ILike(e.IdEstadoEventoNavigation.Descripcion, "%cerr%"))
            .OrderBy(e => e.FechaEvento)
            .Select(e => new EventoDisponibleViewModel
            {
                IdEvento = e.IdEvento,
                CodigoEvento = e.CodigoEvento,
                Nombre = e.Nombre,
                FechaEvento = e.FechaEvento,
                Estado = e.IdEstadoEventoNavigation.Descripcion,
                PrecioInscripcion = e.PrecioInscripcion,
                TotalInscritos = e.Inscripciones.Count
            })
            .ToListAsync(cancellationToken);

        var misInscripciones = await _ctx.Inscripciones
            .AsNoTracking()
            .Include(i => i.IdCaballoNavigation)
            .Include(i => i.IdEventoNavigation)
            .Include(i => i.IdEstadoInscripcionNavigation)
            .Where(i => i.IdCaballoNavigation.IdPropietario == idPropietario)
            .OrderByDescending(i => i.IdEventoNavigation.FechaEvento)
            .ThenByDescending(i => i.FechaInscripcion)
            .Select(i => new InscripcionPropietarioListaViewModel
            {
                IdInscripcion = i.IdInscripcion,
                CodigoEvento = i.IdEventoNavigation.CodigoEvento,
                Evento = i.IdEventoNavigation.Nombre,
                FechaEvento = i.IdEventoNavigation.FechaEvento,
                Caballo = i.IdCaballoNavigation.Nombre,
                FechaInscripcion = i.FechaInscripcion,
                EstadoInscripcion = i.IdEstadoInscripcionNavigation.Descripcion,
                PosicionSalida = i.PosicionSalida
            })
            .ToListAsync(cancellationToken);

        return new InscripcionesEventoPageViewModel
        {
            CaballosDisponibles = caballos,
            EventosDisponibles = eventosDisponibles,
            MisInscripciones = misInscripciones
        };
    }

    public async Task<(bool Ok, string Mensaje)> InscribirAsync(string usuarioLogin, InscribirEventoInputViewModel input, CancellationToken cancellationToken = default)
    {
        var idPropietario = await ObtenerIdPropietarioAsync(usuarioLogin, cancellationToken);
        if (idPropietario is null)
        {
            return (false, "No se encontro el propietario asociado al usuario autenticado.");
        }

        var caballo = await _ctx.Caballos
            .AsNoTracking()
            .Where(c => c.IdCaballo == input.IdCaballo)
            .Select(c => new { c.IdCaballo, c.IdPropietario, c.Activo, c.Nombre })
            .FirstOrDefaultAsync(cancellationToken);

        if (caballo is null || caballo.IdPropietario != idPropietario || caballo.Activo != true)
        {
            return (false, "El caballo seleccionado no esta disponible para inscripcion.");
        }

        var certificacionVigente = await TieneCertificacionVigenteAsync(input.IdCaballo, cancellationToken);
        if (!certificacionVigente)
        {
            return (false, "El caballo seleccionado no tiene una certificacion veterinaria vigente.");
        }

        var evento = await _ctx.Eventos
            .AsNoTracking()
            .Include(e => e.IdEstadoEventoNavigation)
            .Where(e => e.IdEvento == input.IdEvento)
            .Select(e => new
            {
                e.IdEvento,
                e.FechaEvento,
                Estado = e.IdEstadoEventoNavigation.Descripcion
            })
            .FirstOrDefaultAsync(cancellationToken);

        if (evento is null)
        {
            return (false, "El evento no existe.");
        }

        var estadoEvento = evento.Estado.ToLowerInvariant();
        if (evento.FechaEvento.Date < DateTime.Today
            || estadoEvento.Contains("cancel")
            || estadoEvento.Contains("final")
            || estadoEvento.Contains("cerr"))
        {
            return (false, "Este evento no admite nuevas inscripciones.");
        }

        var yaInscrito = await _ctx.Inscripciones
            .AsNoTracking()
            .AnyAsync(i => i.IdEvento == input.IdEvento && i.IdCaballo == input.IdCaballo, cancellationToken);

        if (yaInscrito)
        {
            return (false, "Este caballo ya esta inscrito en el evento seleccionado.");
        }

        var idEstadoInscripcion = await ObtenerEstadoInscripcionInicialAsync(cancellationToken);
        if (idEstadoInscripcion is null)
        {
            return (false, "No se encontro un estado de inscripcion configurado en el sistema.");
        }

        try
        {
            await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
                CALL public.sp_insert_inscripcion(
                    {input.IdEvento},
                    {input.IdCaballo},
                    {null},
                    {idEstadoInscripcion.Value}
                )
                """, cancellationToken);
        }
        catch (DbUpdateException ex) when (EsViolacionPkInscripciones(ex))
        {
            await SincronizarSecuenciaInscripcionesAsync(cancellationToken);

            try
            {
                await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
                    CALL public.sp_insert_inscripcion(
                        {input.IdEvento},
                        {input.IdCaballo},
                        {null},
                        {idEstadoInscripcion.Value}
                    )
                    """, cancellationToken);
            }
            catch (DbUpdateException retryEx) when (EsViolacionPkInscripciones(retryEx))
            {
                return (false, "No se pudo registrar la inscripcion por un problema interno de numeracion. Intenta nuevamente.");
            }
        }

        var observaciones = string.IsNullOrWhiteSpace(input.Observaciones) ? null : input.Observaciones.Trim();
        if (!string.IsNullOrWhiteSpace(observaciones))
        {
            var ultimaInscripcion = await _ctx.Inscripciones
                .Where(i => i.IdEvento == input.IdEvento && i.IdCaballo == input.IdCaballo)
                .OrderByDescending(i => i.IdInscripcion)
                .FirstOrDefaultAsync(cancellationToken);

            if (ultimaInscripcion is not null)
            {
                ultimaInscripcion.Observaciones = observaciones;
                await _ctx.SaveChangesAsync(cancellationToken);
            }
        }

        return (true, "Inscripcion registrada exitosamente.");
    }

    private async Task<int?> ObtenerIdPropietarioAsync(string usuarioLogin, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(usuarioLogin))
        {
            return null;
        }

        return await _ctx.Usuarios
            .AsNoTracking()
            .Where(u => u.Usuario1 == usuarioLogin)
            .Select(u => u.Propietario != null ? (int?)u.Propietario.IdPropietario : null)
            .FirstOrDefaultAsync(cancellationToken);
    }

    private async Task<int?> ObtenerEstadoInscripcionInicialAsync(CancellationToken cancellationToken)
    {
        var estadoPrioritario = await _ctx.TcEstadoInscripcions
            .AsNoTracking()
            .OrderBy(e => e.IdEstadoInscripcion)
            .Where(e =>
                EF.Functions.ILike(e.Descripcion, "%pend%")
                || EF.Functions.ILike(e.Descripcion, "%registr%")
                || EF.Functions.ILike(e.Descripcion, "%activ%"))
            .Select(e => (int?)e.IdEstadoInscripcion)
            .FirstOrDefaultAsync(cancellationToken);

        if (estadoPrioritario is not null)
        {
            return estadoPrioritario;
        }

        return await _ctx.TcEstadoInscripcions
            .AsNoTracking()
            .OrderBy(e => e.IdEstadoInscripcion)
            .Select(e => (int?)e.IdEstadoInscripcion)
            .FirstOrDefaultAsync(cancellationToken);
    }

    private async Task SincronizarSecuenciaInscripcionesAsync(CancellationToken cancellationToken)
    {
        await _ctx.Database.ExecuteSqlRawAsync("""
            SELECT setval(
                COALESCE(pg_get_serial_sequence('public.inscripciones', 'id_inscripcion'), 'public.inscripciones_id_inscripcion_seq'),
                COALESCE((SELECT MAX(id_inscripcion) FROM public.inscripciones), 0) + 1,
                false
            );
            """, cancellationToken);
    }

    private async Task<bool> TieneCertificacionVigenteAsync(int idCaballo, CancellationToken cancellationToken)
    {
        var vigente = await _ctx.Database
            .SqlQueryRaw<bool>($"SELECT public.fn_certificacion_vigente({idCaballo})")
            .FirstOrDefaultAsync(cancellationToken);

        return vigente;
    }

    private static bool EsViolacionPkInscripciones(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "inscripciones_pkey", StringComparison.OrdinalIgnoreCase);
    }
}
