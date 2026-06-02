using Microsoft.AspNetCore.Mvc;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class SuministrosController : Controller
{
    private readonly SuministroService _svc;

    public SuministrosController(SuministroService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var lista = await _svc.ObtenerListaAsync();
            return View(lista);
        }
        catch
        {
            TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo.";
            return View(new List<SuministroListaViewModel>());
        }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new SuministroViewModel();
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo cargar catalogos para suministros.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(SuministroViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.CrearAsync(vm);
            TempData["Exito"] = "Suministro creado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
    }

    public async Task<IActionResult> Editar(int id)
    {
        var vm = await _svc.ObtenerParaEditarAsync(id);
        if (vm is null) return NotFound();

        await _svc.CargarSelectsAsync(vm);
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int id, SuministroViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.EditarAsync(id, vm);
            TempData["Exito"] = "Suministro actualizado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Desactivar(int id)
    {
        try
        {
            await _svc.DesactivarAsync(id);
            TempData["Exito"] = "Suministro desactivado.";
        }
        catch (Exception ex)
        {
            TempData["Error"] = ex.Message;
        }

        return RedirectToAction(nameof(Index));
    }
}
