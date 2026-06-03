using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

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
        var carrera = new Evento
        {
            CodigoEvento = vm.CodigoEvento,
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
        await _ctx.SaveChangesAsync();
    }

    public async Task EditarAsync(int id, CarreraViewModel vm)
    {
        var carrera = await _ctx.Eventos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        carrera.CodigoEvento = vm.CodigoEvento;
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
        var yaInscrito = await _ctx.Inscripciones
            .AnyAsync(i => i.IdEvento == vm.IdEvento && i.IdCaballo == vm.IdCaballo);

        if (yaInscrito)
        {
            throw new InvalidOperationException("Este caballo ya está inscrito en la carrera.");
        }

        var inscripcion = new Inscripcione
        {
            IdEvento = vm.IdEvento,
            IdCaballo = vm.IdCaballo,
            FechaInscripcion = DateTime.Now,
            PosicionSalida = vm.PosicionSalida,
            IdEstadoInscripcion = vm.IdEstadoInscripcion,
            Observaciones = vm.Observaciones
        };

        _ctx.Inscripciones.Add(inscripcion);
        await _ctx.SaveChangesAsync();
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
    }
}
