using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;

namespace Hipodromo_Nacional.Controllers;

public class HomeController : Controller
{
    private readonly PostgresContext _ctx;

    public HomeController(PostgresContext ctx) => _ctx = ctx;

    public async Task<IActionResult> Index()
    {
        try
        {
            ViewBag.TotalCaballos     = await _ctx.Caballos.CountAsync(c => c.Activo == true);
            ViewBag.TotalEstablos     = await _ctx.Establos.CountAsync();
            ViewBag.TotalAsignaciones = await _ctx.AsignacionesEstablos.CountAsync(a => a.Activa == true);
            ViewBag.TotalPropietarios = await _ctx.Propietarios.CountAsync();
            ViewBag.TotalHistorial    = await _ctx.Database
                                            .SqlQueryRaw<int>("SELECT COUNT(*)::int FROM historial_veterinario")
                                            .ToListAsync()
                                            .ContinueWith(t => t.Result.FirstOrDefault());
            ViewBag.ConexionError = false;
        }
        catch
        {
            ViewBag.TotalCaballos = ViewBag.TotalEstablos = ViewBag.TotalAsignaciones =
            ViewBag.TotalPropietarios = ViewBag.TotalHistorial = "—";
            ViewBag.ConexionError = true;
        }

        return View();
    }
}
