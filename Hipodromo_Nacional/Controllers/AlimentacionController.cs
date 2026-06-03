using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador + "," + AppRoles.EncargadoDeEstablo)]
public class AlimentacionController : Controller
{
    private readonly AlimentacionService _svc;

    public AlimentacionController(AlimentacionService svc) => _svc = svc;

    public async Task<IActionResult> Index([FromQuery, Bind(Prefix = "Filtro")] AlimentacionFiltroViewModel filtro)
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(8));

        try
        {
            await _svc.CargarFiltrosAsync(filtro, cts.Token);
            var lista = await _svc.ObtenerListaAsync(filtro, cts.Token);

            var vm = new AlimentacionIndexViewModel
            {
                Filtro = filtro,
                Registros = lista
            };
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo.";
            await _svc.CargarFiltrosAsync(filtro, cts.Token);
            return View(new AlimentacionIndexViewModel
            {
                Filtro = filtro,
                Registros = []
            });
        }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(8));
            var vm = new AlimentacionViewModel();
            await _svc.CargarSelectsAsync(vm, cts.Token);
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo cargar catalogos para alimentacion.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerSuministros(int idTipoSuministro)
    {
        var items = await _svc.ObtenerSuministrosPorTipoAsync(idTipoSuministro);
        return Json(items.Select(i => new { value = i.Value, text = i.Text }));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(AlimentacionViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(8));
            await _svc.CargarSelectsAsync(vm, cts.Token);
            return View(vm);
        }

        try
        {
            await _svc.RegistrarAsync(vm);
            TempData["Exito"] = "Consumo de alimentacion registrado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(8));
            await _svc.CargarSelectsAsync(vm, cts.Token);
            return View(vm);
        }
    }
}
