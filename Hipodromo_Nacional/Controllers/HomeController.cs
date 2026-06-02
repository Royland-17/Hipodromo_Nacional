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
        var caballosTask = SafeCountAsync(ct => _ctx.Caballos.CountAsync(c => c.Activo == true, ct));
        var establosTask = SafeCountAsync(ct => _ctx.Establos.CountAsync(ct));
        var asignacionesTask = SafeCountAsync(ct => _ctx.AsignacionesEstablos.CountAsync(a => a.Activa == true, ct));
        var historialTask = SafeCountAsync(ct => _ctx.HvDefaults.CountAsync(ct));

        await Task.WhenAll(caballosTask, establosTask, asignacionesTask, historialTask);

        ViewBag.TotalCaballos = caballosTask.Result;
        ViewBag.TotalEstablos = establosTask.Result;
        ViewBag.TotalAsignaciones = asignacionesTask.Result;
        ViewBag.TotalHistorial = historialTask.Result;
        ViewBag.ConexionError = caballosTask.Result is string ||
                                establosTask.Result is string ||
                                asignacionesTask.Result is string ||
                                historialTask.Result is string;

        return View();
    }

    private static async Task<object> SafeCountAsync(Func<CancellationToken, Task<int>> query)
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        try
        {
            return await query(timeout.Token);
        }
        catch
        {
            return "—";
        }
    }
}
