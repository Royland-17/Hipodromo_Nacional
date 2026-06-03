using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador + "," + AppRoles.Propietario)]
public class FacturacionController : Controller
{
    private readonly FacturacionService _svc;

    public FacturacionController(FacturacionService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var esAdministrador = User.IsInRole(AppRoles.Administrador);
            var idPropietario = esAdministrador
                ? null
                : await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);

            if (!esAdministrador && idPropietario is null)
            {
                TempData["Error"] = "Tu usuario no tiene perfil de propietario asociado.";
                return View(new List<FacturaListViewModel>());
            }

            var lista = await _svc.ObtenerListaAsync(idPropietario);
            return View(lista);
        }
        catch { TempData["Error"] = "No se pudo cargar las facturas."; return View(new List<FacturaListViewModel>()); }
    }

    public async Task<IActionResult> Detalle(int id)
    {
        var esAdministrador = User.IsInRole(AppRoles.Administrador);
        var idPropietario = esAdministrador
            ? null
            : await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);

        var vm = await _svc.ObtenerDetalleAsync(id, idPropietario);
        if (vm is null) return NotFound();
        return View(vm);
    }

    [Authorize(Roles = AppRoles.Administrador)]
    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new CrearFacturaViewModel();
            await _svc.CargarSelectsCrearAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo cargar el formulario."; return RedirectToAction(nameof(Index)); }
    }

    [Authorize(Roles = AppRoles.Administrador)]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(CrearFacturaViewModel vm)
    {
        if (!vm.InscripcionesSeleccionadas.Any())
            ModelState.AddModelError("", "Debes seleccionar al menos una inscripción.");

        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsCrearAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.CrearAsync(vm);
            TempData["Exito"] = "Factura creada exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (InvalidOperationException ex)
        {
            ModelState.AddModelError(nameof(vm.NumeroFactura), ex.Message);
            await _svc.CargarSelectsCrearAsync(vm);
            return View(vm);
        }
        catch
        {
            ModelState.AddModelError(string.Empty, "No se pudo crear la factura por un error inesperado.");
            await _svc.CargarSelectsCrearAsync(vm);
            return View(vm);
        }
    }

    public async Task<IActionResult> RegistrarPago(int id)
    {
        var esAdministrador = User.IsInRole(AppRoles.Administrador);
        var idPropietario = esAdministrador
            ? null
            : await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);

        var factura = await _svc.ObtenerDetalleAsync(id, idPropietario);
        if (factura is null) return NotFound();

        var vm = new RegistrarPagoViewModel
        {
            IdFactura     = factura.IdFactura,
            NumeroFactura = factura.NumeroFactura,
            TotalFactura  = factura.Total
        };
        await _svc.CargarSelectsPagoAsync(vm);
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RegistrarPago(RegistrarPagoViewModel vm)
    {
        var esAdministrador = User.IsInRole(AppRoles.Administrador);
        var idPropietario = esAdministrador
            ? null
            : await _svc.ObtenerIdPropietarioPorUsuarioAsync(User.Identity?.Name ?? string.Empty);

        var facturaPermitida = await _svc.ObtenerDetalleAsync(vm.IdFactura, idPropietario);
        if (facturaPermitida is null)
            return NotFound();

        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsPagoAsync(vm);
            return View(vm);
        }

        await _svc.RegistrarPagoAsync(vm);
        TempData["Exito"] = "Pago registrado exitosamente.";
        return RedirectToAction(nameof(Detalle), new { id = vm.IdFactura });
    }
}
