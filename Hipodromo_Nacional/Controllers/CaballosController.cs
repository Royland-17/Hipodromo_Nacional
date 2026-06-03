using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador + "," + AppRoles.Propietario)]
public class CaballosController : Controller
{
    private readonly CaballoService _svc;

    public CaballosController(CaballoService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var usuarioLogin = User.Identity?.Name ?? string.Empty;
            var esAdministrador = User.IsInRole(AppRoles.Administrador);
            var lista = await _svc.ObtenerListaAsync(usuarioLogin, esAdministrador);
            return View(lista);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<CaballoListaViewModel>()); }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new CaballoViewModel
            {
                Codigo = await _svc.GenerarCodigoAutomaticoAsync()
            };
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(CaballoViewModel vm)
    {
        var usuarioLogin = User.Identity?.Name ?? string.Empty;
        var idPropietarioActual = await _svc.ObtenerIdPropietarioPorUsuarioAsync(usuarioLogin);
        if (idPropietarioActual is null)
        {
            TempData["Error"] = "Tu usuario no tiene un perfil de propietario asociado para registrar caballos.";
            return RedirectToAction(nameof(Index));
        }

        vm.IdPropietario = idPropietarioActual.Value;

        if (!ModelState.IsValid)
        {
            if (string.IsNullOrWhiteSpace(vm.Codigo))
                vm.Codigo = await _svc.GenerarCodigoAutomaticoAsync();

            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.CrearAsync(vm, idPropietarioActual.Value);
            TempData["Exito"] = "Caballo registrado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (InvalidOperationException ex)
        {
            ModelState.AddModelError(nameof(vm.Codigo), ex.Message);
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
    }

    public async Task<IActionResult> Editar(int id)
    {
        var caballo = await _svc.ObtenerPorIdAsync(id);
        if (caballo is null) return NotFound();

        var idPropietarioActual = await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);
        if (idPropietarioActual is null || caballo.IdPropietario != idPropietarioActual.Value)
        {
            TempData["Error"] = "No puedes editar caballos de otro usuario.";
            return RedirectToAction(nameof(Index));
        }

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
        var idPropietarioActual = await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);
        if (idPropietarioActual is null)
        {
            TempData["Error"] = "Tu usuario no tiene un perfil de propietario asociado.";
            return RedirectToAction(nameof(Index));
        }

        vm.IdPropietario = idPropietarioActual.Value;

        if (!ModelState.IsValid)
        {
            var caballoActual = await _svc.ObtenerPorIdAsync(id);
            if (caballoActual is not null)
                vm.Codigo = caballoActual.Codigo;

            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.EditarAsync(id, vm, idPropietarioActual.Value);
        }
        catch (InvalidOperationException ex)
        {
            ModelState.AddModelError(nameof(vm.Codigo), ex.Message);
            var caballoActual = await _svc.ObtenerPorIdAsync(id);
            if (caballoActual is not null)
                vm.Codigo = caballoActual.Codigo;

            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        catch (UnauthorizedAccessException)
        {
            TempData["Error"] = "No puedes editar caballos de otro usuario.";
            return RedirectToAction(nameof(Index));
        }

        TempData["Exito"] = "Caballo actualizado exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Desactivar(int id)
    {
        var idPropietarioActual = await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);
        if (idPropietarioActual is null)
        {
            TempData["Error"] = "Tu usuario no tiene un perfil de propietario asociado.";
            return RedirectToAction(nameof(Index));
        }

        try
        {
            await _svc.EliminarAsync(id, idPropietarioActual.Value);
        }
        catch (UnauthorizedAccessException)
        {
            TempData["Error"] = "No puedes desactivar caballos de otro usuario.";
            return RedirectToAction(nameof(Index));
        }

        TempData["Exito"] = "Caballo desactivado.";
        return RedirectToAction(nameof(Index));
    }
}
