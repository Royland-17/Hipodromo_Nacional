using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Propietario)]
public class InscripcionesEventosController : Controller
{
    private readonly InscripcionesEventoService _service;

    public InscripcionesEventosController(InscripcionesEventoService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var usuarioLogin = User.Identity?.Name ?? string.Empty;
        var vm = await _service.ObtenerPantallaAsync(usuarioLogin);
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Inscribir(InscribirEventoInputViewModel input)
    {
        if (!ModelState.IsValid)
        {
            TempData["Error"] = "Datos invalidos para registrar la inscripcion.";
            return RedirectToAction(nameof(Index));
        }

        var usuarioLogin = User.Identity?.Name ?? string.Empty;
        var resultado = await _service.InscribirAsync(usuarioLogin, input);

        if (resultado.Ok)
        {
            TempData["Exito"] = resultado.Mensaje;
        }
        else
        {
            TempData["Error"] = resultado.Mensaje;
        }

        return RedirectToAction(nameof(Index));
    }
}
