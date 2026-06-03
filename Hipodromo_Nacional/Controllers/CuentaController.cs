using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo_Nacional.Controllers;

[Authorize]
public class CuentaController : Controller
{
    private readonly PostgresContext _ctx;

    public CuentaController(PostgresContext ctx) => _ctx = ctx;

    public async Task<IActionResult> MiUsuario()
    {
        var usuarioLogin = User.Identity?.Name;
        if (string.IsNullOrWhiteSpace(usuarioLogin))
        {
            TempData["Error"] = "No se pudo determinar el usuario autenticado.";
            return RedirectToAction("Index", "Home");
        }

        var vm = await _ctx.Usuarios
            .AsNoTracking()
            .Include(u => u.IdRolNavigation)
            .Where(u => u.Usuario1 == usuarioLogin)
            .Select(u => new UsuarioActualViewModel
            {
                IdUsuario = u.IdUsuario,
                Usuario = u.Usuario1,
                NombreCompleto = (u.Nombre + " " + u.Apellido1 + (u.Apellido2 != null ? " " + u.Apellido2 : "")).Trim(),
                Rol = u.IdRolNavigation.Descripcion,
                Identificacion = u.Identificacion,
                Activo = u.Activo ?? true,
                IdPropietario = u.Propietario != null ? (int?)u.Propietario.IdPropietario : null,
                IdVeterinario = u.Veterinario != null ? (int?)u.Veterinario.IdVeterinario : null
            })
            .FirstOrDefaultAsync();

        if (vm is null)
        {
            TempData["Error"] = "No se encontro el usuario autenticado en la base de datos.";
            return RedirectToAction("Index", "Home");
        }

        return View(vm);
    }
}
