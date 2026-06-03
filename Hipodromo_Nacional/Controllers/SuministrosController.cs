using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador + "," + AppRoles.EncargadoDeEstablo)]
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
            var vm = new SuministroViewModel
            {
                FechaIngreso = DateOnly.FromDateTime(DateTime.Today),
                Codigo = await _svc.GenerarCodigoAutomaticoAsync()
            };
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
        vm.FechaIngreso = DateOnly.FromDateTime(DateTime.Today);
        vm.Codigo = await _svc.GenerarCodigoAutomaticoAsync();
        ModelState.Remove(nameof(SuministroViewModel.FechaIngreso));
        ModelState.Remove(nameof(SuministroViewModel.Codigo));

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
    public async Task<IActionResult> Activar(int id)
    {
        try
        {
            await _svc.ActivarAsync(id);
            TempData["Exito"] = "Suministro activado.";
        }
        catch (Exception ex)
        {
            TempData["Error"] = ex.Message;
        }

        return RedirectToAction(nameof(Index));
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
