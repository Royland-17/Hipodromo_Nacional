using Microsoft.AspNetCore.Mvc;
using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class CarrerasController : Controller
{
    private readonly CarreraService _svc;

    public CarrerasController(CarreraService svc) => _svc = svc;

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
            return View(new List<CarreraListaViewModel>());
        }
    }

    public async Task<IActionResult> ControlInscripciones()
    {
        try
        {
            var lista = await _svc.ObtenerListaAsync();
            return View(lista);
        }
        catch
        {
            TempData["Error"] = "No se pudo conectar a la base de datos. Intenta de nuevo.";
            return View(new List<CarreraListaViewModel>());
        }
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new CarreraViewModel();
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(CarreraViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.CrearAsync(vm);
            TempData["Exito"] = "Carrera registrada exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            TempData["Error"] = "No se pudo guardar la carrera. Verifica que el código no esté repetido y que el contador de eventos esté actualizado.";
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }
    }

    public async Task<IActionResult> Editar(int id)
    {
        var carrera = await _svc.ObtenerPorIdAsync(id);
        if (carrera is null) return NotFound();

        var vm = new CarreraViewModel
        {
            IdEvento = carrera.IdEvento,
            CodigoEvento = carrera.CodigoEvento,
            Nombre = carrera.Nombre,
            FechaEvento = carrera.FechaEvento,
            DistanciaMetros = carrera.DistanciaMetros,
            PremioTotal = carrera.PremioTotal,
            PrecioInscripcion = carrera.PrecioInscripcion,
            ComisionAdmin = carrera.ComisionAdmin,
            IdTipoCarrera = carrera.IdTipoCarrera,
            IdEstadoEvento = carrera.IdEstadoEvento,
            Observaciones = carrera.Observaciones
        };
        await _svc.CargarSelectsAsync(vm);
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int id, CarreraViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsAsync(vm);
            return View(vm);
        }

        await _svc.EditarAsync(id, vm);
        TempData["Exito"] = "Carrera actualizada exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Inscripciones(int id)
    {
        try
        {
            var vm = await _svc.ObtenerInscripcionesAsync(id);
            if (vm is null) return NotFound();
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo.";
            return RedirectToAction(nameof(Index));
        }
    }

    public async Task<IActionResult> RegistrarInscripcion(int id)
    {
        try
        {
            var vm = new InscripcionCarreraViewModel { IdEvento = id };
            await _svc.CargarSelectsInscripcionAsync(vm);
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo preparar el registro de inscripción.";
            return RedirectToAction(nameof(Inscripciones), new { id });
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RegistrarInscripcion(InscripcionCarreraViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await _svc.CargarSelectsInscripcionAsync(vm);
            return View(vm);
        }

        try
        {
            await _svc.CrearInscripcionAsync(vm);
            TempData["Exito"] = "Caballo inscrito en la carrera exitosamente.";
            return RedirectToAction(nameof(Inscripciones), new { id = vm.IdEvento });
        }
        catch (InvalidOperationException ex)
        {
            ModelState.AddModelError(nameof(vm.IdCaballo), ex.Message);
            await _svc.CargarSelectsInscripcionAsync(vm);
            return View(vm);
        }
    }

    public async Task<IActionResult> Resultados(int id)
    {
        try
        {
            var vm = await _svc.ObtenerResultadosAsync(id);
            if (vm is null) return NotFound();
            return View(vm);
        }
        catch
        {
            TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo.";
            return RedirectToAction(nameof(Index));
        }
    }

    public async Task<IActionResult> RegistrarResultado(int id)
    {
        var vm = await _svc.ObtenerResultadoFormAsync(id);
        if (vm is null) return NotFound();
        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RegistrarResultado(ResultadoCarreraViewModel vm)
    {
        if (vm.Descalificado && string.IsNullOrWhiteSpace(vm.MotivoDescalificacion))
        {
            ModelState.AddModelError(nameof(vm.MotivoDescalificacion), "Indica el motivo de descalificación.");
        }

        if (!ModelState.IsValid)
        {
            var form = await _svc.ObtenerResultadoFormAsync(vm.IdInscripcion);
            if (form is null) return NotFound();

            vm.Carrera = form.Carrera;
            vm.Caballo = form.Caballo;
            vm.CodigoCaballo = form.CodigoCaballo;
            return View(vm);
        }

        await _svc.GuardarResultadoAsync(vm);
        TempData["Exito"] = "Resultado registrado exitosamente.";
        return RedirectToAction(nameof(Resultados), new { id = vm.IdEvento });
    }
}
