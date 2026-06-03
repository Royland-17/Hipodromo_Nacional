using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class ReportesController : Controller
{
    private readonly PostgresContext _ctx;

    public ReportesController(PostgresContext ctx) => _ctx = ctx;

    public async Task<IActionResult> Resultados(string? evento)
    {
        try
        {
            var todos = await _ctx.VwResultadosEventos.ToListAsync();

            var eventos = todos
                .Where(r => r.Evento != null)
                .Select(r => r.Evento!)
                .Distinct()
                .OrderBy(e => e)
                .ToList();

            var filtrados = string.IsNullOrEmpty(evento)
                ? todos
                : todos.Where(r => r.Evento == evento).ToList();

            var resultados = filtrados
                .OrderBy(r => r.FechaEvento)
                .ThenBy(r => r.PosicionFinal)
                .Select(r => new ResultadoEventoViewModel
                {
                    CodigoEvento  = r.CodigoEvento ?? "",
                    Evento        = r.Evento ?? "",
                    FechaEvento   = r.FechaEvento,
                    PosicionFinal = r.PosicionFinal,
                    Caballo       = r.Caballo ?? "",
                    Propietario   = r.Propietario ?? "",
                    TiempoSegundos = r.TiempoSegundos,
                    PremioObtenido = r.PremioObtenido,
                    Descalificado  = r.Descalificado
                }).ToList();

            var ranking = todos
                .Where(r => r.Caballo != null && r.Descalificado != true)
                .GroupBy(r => new { r.Caballo, r.Propietario })
                .Select(g => new RankingCaballoViewModel
                {
                    Caballo           = g.Key.Caballo!,
                    Propietario       = g.Key.Propietario ?? "",
                    Participaciones   = g.Count(),
                    Victorias         = g.Count(r => r.PosicionFinal == 1),
                    Podios            = g.Count(r => r.PosicionFinal <= 3),
                    PremiosAcumulados = g.Sum(r => r.PremioObtenido ?? 0)
                })
                .OrderByDescending(r => r.Victorias)
                .ThenByDescending(r => r.Podios)
                .ThenByDescending(r => r.PremiosAcumulados)
                .ToList();

            var vm = new ReporteResultadosViewModel
            {
                Resultados   = resultados,
                Ranking      = ranking,
                Eventos      = eventos,
                EventoFiltro = evento
            };

            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo cargar el reporte.";
            return View(new ReporteResultadosViewModel());
        }
    }
}
