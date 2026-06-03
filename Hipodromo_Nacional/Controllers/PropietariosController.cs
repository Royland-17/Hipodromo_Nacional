using Hipodromo_Nacional.Hipodromo.BL;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.Security;
using Hipodromo_Nacional.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Hipodromo_Nacional.Controllers;

[Authorize(Roles = AppRoles.Administrador)]
public class PropietariosController : Controller
{
    private readonly PropietarioService _service;

    public PropietariosController(PropietarioService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index(string? identificacion)
    {
        var identificacionNormalizada = identificacion?.Trim();
        ViewBag.Identificacion = identificacionNormalizada;
        ViewBag.SeBusco = !string.IsNullOrWhiteSpace(identificacionNormalizada);

        try
        {
            var propietarios = await _service.BuscarPorIdentificacionAsync(identificacionNormalizada);
            return View(propietarios);
        }
        catch (PostgresException ex)
        {
            TempData["Error"] = ex.SqlState == "25P02"
                ? "No se pudo completar la búsqueda porque la conexión quedó en un estado inválido temporal. Intente de nuevo."
                : $"No se pudo completar la búsqueda ({ex.SqlState}).";
            return View(Array.Empty<Propietario>());
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            TempData["Error"] = "No se pudo conectar a la base de datos. Intente de nuevo.";
            return View(Array.Empty<Propietario>());
        }
    }

    public async Task<IActionResult> Detalles(int? id)
    {
        if (id is null) return NotFound();

        try
        {
            var propietario = await _service.ObtenerDetalleAsync(id.Value);

            if (propietario is null) return NotFound();
            return View(propietario);
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            TempData["Error"] = "No se pudo conectar a la base de datos.";
            return RedirectToAction(nameof(Index));
        }
    }

    public async Task<IActionResult> Crear()
    {
        var dto = await _service.ObtenerCreateDtoAsync();
        return View(MapToCreateVm(dto));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(PropietarioViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            var recargado = await _service.RecargarDropdownsCreateAsync(MapToCreateDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }

        try
        {
            await _service.CrearAsync(MapToCreateDto(vm));

            TempData["Exito"] = $"Propietario \"{vm.Nombre} {vm.Apellido1}\" registrado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (DbUpdateException ex)
        {
            var pgEx = ex.InnerException as PostgresException
                ?? ex.GetBaseException() as PostgresException;
            var sqlState = pgEx?.SqlState;
            var constraintName = pgEx?.ConstraintName;
            var mensaje = sqlState switch
            {
                "23505" when string.Equals(constraintName, "usuarios_pkey", StringComparison.OrdinalIgnoreCase)
                    => "No se pudo guardar el propietario porque la secuencia de usuarios está desincronizada. Intente de nuevo.",
                "23505" when string.Equals(constraintName, "propietarios_pkey", StringComparison.OrdinalIgnoreCase)
                    => "No se pudo guardar el propietario porque la secuencia de propietarios está desincronizada. Intente de nuevo.",
                "23505" => "El usuario o la identificación ya existen.",
                "23503" => "La dirección seleccionada no es válida. Seleccione nuevamente país, provincia, cantón, distrito y barrio.",
                "57014" => "No se pudo guardar el propietario porque la operación superó el tiempo de espera. Intente de nuevo.",
                _ => "No se pudo guardar el propietario por un error de base de datos. Revise los datos e intente de nuevo."
            };

            ModelState.AddModelError("", mensaje);
            var recargado = await _service.RecargarDropdownsCreateAsync(MapToCreateDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }
        catch (PostgresException ex)
        {
            var mensaje = ex.SqlState switch
            {
                "23505" when string.Equals(ex.ConstraintName, "usuarios_pkey", StringComparison.OrdinalIgnoreCase)
                    => "No se pudo guardar el propietario porque la secuencia de usuarios está desincronizada. Intente de nuevo.",
                "23505" when string.Equals(ex.ConstraintName, "propietarios_pkey", StringComparison.OrdinalIgnoreCase)
                    => "No se pudo guardar el propietario porque la secuencia de propietarios está desincronizada. Intente de nuevo.",
                "23505" => "El usuario o la identificación ya existen.",
                "23503" => "La dirección seleccionada no es válida. Seleccione nuevamente país, provincia, cantón, distrito y barrio.",
                "25P02" => "No se pudo guardar el propietario porque una operación anterior dentro de la transacción falló. Revise los datos e intente de nuevo.",
                "57014" => "No se pudo guardar el propietario porque la operación superó el tiempo de espera. Intente de nuevo.",
                _ => $"No se pudo guardar el propietario ({ex.SqlState}). Revise los datos e intente de nuevo."
            };

            ModelState.AddModelError("", mensaje);
            var recargado = await _service.RecargarDropdownsCreateAsync(MapToCreateDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            ModelState.AddModelError("", "No se pudo guardar el propietario porque la operación tardó demasiado. Intente de nuevo.");
            var recargado = await _service.RecargarDropdownsCreateAsync(MapToCreateDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }
    }

    public async Task<IActionResult> Editar(int? id)
    {
        if (id is null) return NotFound();

        try
        {
            var dto = await _service.ObtenerEditDtoAsync(id.Value);

            if (dto is null) return NotFound();

            return View(MapToEditVm(dto));
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            TempData["Error"] = "No se pudo cargar el propietario.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int id, PropietarioEditViewModel vm)
    {
        if (id != vm.IdPropietario) return NotFound();

        if (string.IsNullOrWhiteSpace(vm.Contrasena))
            ModelState.Remove(nameof(vm.Contrasena));

        if (!ModelState.IsValid)
        {
            var recargado = await _service.RecargarDropdownsEditAsync(MapToEditDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }

        try
        {
            var updated = await _service.ActualizarAsync(id, MapToEditDto(vm));
            if (!updated) return NotFound();

            TempData["Exito"] = "Propietario actualizado correctamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (DbUpdateConcurrencyException)
        {
            ModelState.AddModelError("", "El registro fue modificado por otro usuario.");
            var recargado = await _service.RecargarDropdownsEditAsync(MapToEditDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }
        catch (PostgresException ex)
        {
            var mensaje = ex.SqlState switch
            {
                "23505" => "El usuario o la identificación ya existen.",
                "23503" => "La dirección seleccionada no es válida. Seleccione nuevamente país, provincia, cantón, distrito y barrio.",
                "25P02" => "No se pudo actualizar el propietario porque una operación anterior dentro de la transacción falló. Revise los datos e intente de nuevo.",
                "57014" => "No se pudo actualizar el propietario porque la operación superó el tiempo de espera. Intente de nuevo.",
                _ => $"No se pudo actualizar el propietario ({ex.SqlState}). Revise los datos e intente de nuevo."
            };

            ModelState.AddModelError("", mensaje);
            var recargado = await _service.RecargarDropdownsEditAsync(MapToEditDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            ModelState.AddModelError("", "No se pudo actualizar el propietario porque la operación tardó demasiado. Intente de nuevo.");
            var recargado = await _service.RecargarDropdownsEditAsync(MapToEditDto(vm));
            ApplyDropdowns(vm, recargado);
            return View(vm);
        }
    }

    public async Task<IActionResult> Desactivar(int? id)
    {
        if (id is null) return NotFound();

        try
        {
            var propietario = await _service.ObtenerDeleteVmAsync(id.Value);

            if (propietario is null) return NotFound();
            return View(propietario);
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            TempData["Error"] = "No se pudo cargar el registro.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpPost, ActionName("Desactivar")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DesactivarConfirmado(int id)
    {
        try
        {
            var result = await _service.DesactivarAsync(id);

            if (result.NotFound) return NotFound();

            TempData["Exito"] = result.AlreadyApplied
                ? "Propietario ya estaba desactivado."
                : "Propietario desactivado correctamente.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            TempData["Error"] = "Error al eliminar. Intente de nuevo.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerProvincias(int idPais)
    {
        try
        {
            var items = await _service.ObtenerProvinciasAsync(idPais);
            return Json(items);
        }
        catch (PostgresException ex)
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = $"No se pudieron cargar provincias ({ex.SqlState})." });
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = "No se pudieron cargar provincias." });
        }
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerCantones(int idProvincia)
    {
        try
        {
            var items = await _service.ObtenerCantonesAsync(idProvincia);
            return Json(items);
        }
        catch (PostgresException ex)
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = $"No se pudieron cargar cantones ({ex.SqlState})." });
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = "No se pudieron cargar cantones." });
        }
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerDistritos(int idCanton)
    {
        try
        {
            var items = await _service.ObtenerDistritosAsync(idCanton);
            return Json(items);
        }
        catch (PostgresException ex)
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = $"No se pudieron cargar distritos ({ex.SqlState})." });
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = "No se pudieron cargar distritos." });
        }
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerBarrios(int idDistrito)
    {
        try
        {
            var items = await _service.ObtenerBarriosAsync(idDistrito);
            return Json(items);
        }
        catch (PostgresException ex)
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = $"No se pudieron cargar barrios ({ex.SqlState})." });
        }
        catch (Exception ex) when (IsTransient(ex))
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable, new { message = "No se pudieron cargar barrios." });
        }
    }

    private static PropietarioCreateDto MapToCreateDto(PropietarioViewModel vm) => new()
    {
        IdPropietario = vm.IdPropietario,
        Usuario = vm.Usuario,
        Contrasena = vm.Contrasena,
        Nombre = vm.Nombre,
        Apellido1 = vm.Apellido1,
        Apellido2 = vm.Apellido2,
        Identificacion = vm.Identificacion,
        IdPais = vm.IdPais,
        IdProvincia = vm.IdProvincia,
        IdCanton = vm.IdCanton,
        IdDistrito = vm.IdDistrito,
        IdBarrio = vm.IdBarrio,
        DireccionExacta = vm.DireccionExacta
    };

    private static PropietarioEditDto MapToEditDto(PropietarioEditViewModel vm) => new()
    {
        IdPropietario = vm.IdPropietario,
        IdUsuario = vm.IdUsuario,
        Usuario = vm.Usuario,
        Contrasena = vm.Contrasena,
        Nombre = vm.Nombre,
        Apellido1 = vm.Apellido1,
        Apellido2 = vm.Apellido2,
        Identificacion = vm.Identificacion,
        IdPais = vm.IdPais,
        IdProvincia = vm.IdProvincia,
        IdCanton = vm.IdCanton,
        IdDistrito = vm.IdDistrito,
        IdBarrio = vm.IdBarrio,
        DireccionExacta = vm.DireccionExacta
    };

    private static PropietarioViewModel MapToCreateVm(PropietarioCreateDto dto)
    {
        var vm = new PropietarioViewModel
        {
            IdPropietario = dto.IdPropietario,
            Usuario = dto.Usuario,
            Contrasena = dto.Contrasena,
            Nombre = dto.Nombre,
            Apellido1 = dto.Apellido1,
            Apellido2 = dto.Apellido2,
            Identificacion = dto.Identificacion,
            IdPais = dto.IdPais,
            IdProvincia = dto.IdProvincia,
            IdCanton = dto.IdCanton,
            IdDistrito = dto.IdDistrito,
            IdBarrio = dto.IdBarrio,
            DireccionExacta = dto.DireccionExacta
        };

        ApplyDropdowns(vm, dto);
        return vm;
    }

    private static PropietarioEditViewModel MapToEditVm(PropietarioEditDto dto)
    {
        var vm = new PropietarioEditViewModel
        {
            IdPropietario = dto.IdPropietario,
            IdUsuario = dto.IdUsuario,
            Usuario = dto.Usuario,
            Contrasena = dto.Contrasena,
            Nombre = dto.Nombre,
            Apellido1 = dto.Apellido1,
            Apellido2 = dto.Apellido2,
            Identificacion = dto.Identificacion,
            IdPais = dto.IdPais,
            IdProvincia = dto.IdProvincia,
            IdCanton = dto.IdCanton,
            IdDistrito = dto.IdDistrito,
            IdBarrio = dto.IdBarrio,
            DireccionExacta = dto.DireccionExacta
        };

        ApplyDropdowns(vm, dto);
        return vm;
    }

    private static void ApplyDropdowns(PropietarioViewModel vm, PropietarioCreateDto dto)
    {
        vm.Paises = ToSelectList(dto.Paises, vm.IdPais, "-- Seleccione --");
        vm.Provincias = ToSelectList(dto.Provincias, vm.IdProvincia, "-- Seleccione país primero --");
        vm.Cantones = ToSelectList(dto.Cantones, vm.IdCanton, "-- Seleccione provincia primero --");
        vm.Distritos = ToSelectList(dto.Distritos, vm.IdDistrito, "-- Seleccione cantón primero --");
        vm.Barrios = ToSelectList(dto.Barrios, vm.IdBarrio, "-- Seleccione distrito primero --");
    }

    private static IEnumerable<SelectListItem> ToSelectList(
        IEnumerable<SelectOptionDto> items,
        int selectedValue,
        string placeholder)
    {
        var list = items
            .Select(item => new SelectListItem(item.Text, item.Value.ToString(), item.Value == selectedValue))
            .ToList();

        list.Insert(0, new SelectListItem(placeholder, ""));
        return list;
    }

    private static bool IsTransient(Exception ex)
    {
        for (Exception? current = ex; current is not null; current = current.InnerException)
        {
            if (current is TimeoutException)
                return true;

            var message = current.Message;
            if (message.Contains("timeout", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("timed out", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("connection", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("transient", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}