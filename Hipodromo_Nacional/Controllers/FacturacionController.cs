using Microsoft.AspNetCore.Mvc;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class FacturacionController : Controller
{
    private readonly FacturacionService _svc;

    public FacturacionController(FacturacionService svc) => _svc = svc;

    public async Task<IActionResult> Index()
    {
        try
        {
            var lista = await _svc.ObtenerListaAsync();
            return View(lista);
        }
        catch { TempData["Error"] = "No se pudo cargar las facturas."; return View(new List<FacturaListViewModel>()); }
    }

    public async Task<IActionResult> Detalle(int id)
    {
        var vm = await _svc.ObtenerDetalleAsync(id);
        if (vm is null) return NotFound();
        return View(vm);
    }

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

        await _svc.CrearAsync(vm);
        TempData["Exito"] = "Factura creada exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> RegistrarPago(int id)
    {
        var factura = await _svc.ObtenerDetalleAsync(id);
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
