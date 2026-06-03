using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Propietario)]
public class ResultadosController : Controller
{
    private readonly ResultadosService _svc;

    public ResultadosController(ResultadosService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        var usuarioLogin = User.Identity?.Name ?? string.Empty;
        var resultados = await _svc.ObtenerPorUsuarioAsync(usuarioLogin);
        return View(resultados);
    }
}
