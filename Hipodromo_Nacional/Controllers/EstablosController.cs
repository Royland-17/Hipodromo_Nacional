using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador)]
public class EstablosController : Controller
{
    private readonly EstabloService _svc;

    public EstablosController(EstabloService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var lista = await _svc.ObtenerListaAsync();
            return View(lista);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<EstabloViewModel>()); }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new EstabloViewModel();
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(EstabloViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        await _svc.CrearAsync(vm);
        TempData["Exito"] = "Establo creado exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Editar(int id)
    {
        var establo = await _svc.ObtenerPorIdAsync(id);
        if (establo is null) return NotFound();

        var vm = new EstabloViewModel
        {
            IdEstablo = establo.IdEstablo,
            Codigo = establo.Codigo,
            Nombre = establo.Nombre,
            Ubicacion = establo.Ubicacion,
            Capacidad = establo.Capacidad,
            IdEstadoEstablo = establo.IdEstadoEstablo
        };
        await _svc.CargarSelectsAsync(vm);
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int id, EstabloViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        await _svc.EditarAsync(id, vm);
        TempData["Exito"] = "Establo actualizado exitosamente.";
        return RedirectToAction(nameof(Index));
    }
}
