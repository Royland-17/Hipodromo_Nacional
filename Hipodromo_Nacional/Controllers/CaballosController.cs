using Microsoft.AspNetCore.Mvc;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class CaballosController : Controller
{
    private readonly CaballoService _svc;

    public CaballosController(CaballoService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var lista = await _svc.ObtenerListaAsync();
            return View(lista);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<CaballoListaViewModel>()); }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new CaballoViewModel();
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(CaballoViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        await _svc.CrearAsync(vm);
        TempData["Exito"] = "Caballo registrado exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Editar(int id)
    {
        var caballo = await _svc.ObtenerPorIdAsync(id);
        if (caballo is null) return NotFound();

        var vm = new CaballoViewModel
        {
            IdCaballo = caballo.IdCaballo,
            Codigo = caballo.Codigo,
            Nombre = caballo.Nombre,
            FechaNacimiento = caballo.FechaNacimiento,
            PesoKg = caballo.PesoKg,
            IdSexo = caballo.IdSexo,
            IdRaza = caballo.IdRaza,
            IdEstadoSalud = caballo.IdEstadoSalud,
            IdPropietario = caballo.IdPropietario,
            Activo = caballo.Activo ?? true
        };
        await _svc.CargarSelectsAsync(vm);
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int id, CaballoViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        await _svc.EditarAsync(id, vm);
        TempData["Exito"] = "Caballo actualizado exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Desactivar(int id)
    {
        await _svc.EliminarAsync(id);
        TempData["Exito"] = "Caballo desactivado.";
        return RedirectToAction(nameof(Index));
    }
}
