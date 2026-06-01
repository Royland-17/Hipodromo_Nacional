using Microsoft.AspNetCore.Mvc;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class AsignacionesController : Controller
{
    private readonly EstabloService _svc;

    public AsignacionesController(EstabloService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var lista = await _svc.ObtenerAsignacionesAsync();
            return View(lista);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<AsignacionViewModel>()); }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new AsignacionViewModel();
            await _svc.CargarSelectsAsignacionAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(AsignacionViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsignacionAsync(vm);
            return View(vm);
        }
        await _svc.CrearAsignacionAsync(vm);
        TempData["Exito"] = "Caballo asignado al establo exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Desasignar(int id)
    {
        await _svc.DesasignarAsync(id);
        TempData["Exito"] = "Asignación finalizada.";
        return RedirectToAction(nameof(Index));
    }
}
