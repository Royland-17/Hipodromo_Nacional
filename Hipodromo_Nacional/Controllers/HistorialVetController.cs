using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Controllers;

public class HistorialVetController : Controller
{
    private readonly PostgresContext _ctx;

    public HistorialVetController(PostgresContext ctx) => _ctx = ctx;

    public async Task<IActionResult> Index()
    {
        try { await _ctx.Database.CanConnectAsync(); } catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<HistorialVetViewModel>()); }
        var historial = await _ctx.HvDefaults
            .Include(h => h.IdCaballoNavigation)
            .Include(h => h.IdVeterinarioNavigation)
                .ThenInclude(v => v.IdUsuarioNavigation)
            .OrderByDescending(h => h.FechaRevision)
            .Select(h => new HistorialVetViewModel
            {
                IdHistorial = h.IdHistorial,
                IdCaballo = h.IdCaballo,
                IdVeterinario = h.IdVeterinario,
                FechaRevision = h.FechaRevision,
                Diagnostico = h.Diagnostico,
                Tratamiento = h.Tratamiento,
                Observaciones = h.Observaciones,
                ProximoControl = h.ProximoControl,
                NombreCaballo = h.IdCaballoNavigation.Nombre,
                NombreVeterinario = h.IdVeterinarioNavigation.IdUsuarioNavigation.Nombre
                    + " " + h.IdVeterinarioNavigation.IdUsuarioNavigation.Apellido1
            })
            .ToListAsync();

        return View(historial);
    }

    public async Task<IActionResult> Crear()
    {
        try
        {
            var vm = new HistorialVetViewModel();
            await CargarSelectsAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Index)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(HistorialVetViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await CargarSelectsAsync(vm);
            return View(vm);
        }

        var registro = new HvDefault
        {
            IdCaballo = vm.IdCaballo,
            IdVeterinario = vm.IdVeterinario,
            IdCertificacion = vm.IdCertificacion,
            FechaRevision = vm.FechaRevision,
            Diagnostico = vm.Diagnostico,
            Tratamiento = vm.Tratamiento,
            Observaciones = vm.Observaciones,
            ProximoControl = vm.ProximoControl
        };
        _ctx.HvDefaults.Add(registro);
        await _ctx.SaveChangesAsync();

        TempData["Exito"] = "Registro veterinario guardado exitosamente.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Certificaciones()
    {
        try { await _ctx.Database.CanConnectAsync(); } catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return View(new List<CertificacionViewModel>()); }
        var certs = await _ctx.CertificacionesSanitarias
            .Include(c => c.IdCaballoNavigation)
            .Include(c => c.IdVeterinarioNavigation)
                .ThenInclude(v => v.IdUsuarioNavigation)
            .Include(c => c.IdEstadoCertificacionNavigation)
            .OrderByDescending(c => c.FechaEmision)
            .Select(c => new CertificacionViewModel
            {
                IdCertificacion = c.IdCertificacion,
                IdCaballo = c.IdCaballo,
                IdVeterinario = c.IdVeterinario,
                FechaEmision = c.FechaEmision,
                FechaVencimiento = c.FechaVencimiento,
                NumeroCertificado = c.NumeroCertificado,
                Observaciones = c.Observaciones,
                NombreCaballo = c.IdCaballoNavigation.Nombre,
                NombreVeterinario = c.IdVeterinarioNavigation.IdUsuarioNavigation.Nombre
                    + " " + c.IdVeterinarioNavigation.IdUsuarioNavigation.Apellido1,
                EstadoCertificacion = c.IdEstadoCertificacionNavigation.Descripcion
            })
            .ToListAsync();

        return View(certs);
    }

    public async Task<IActionResult> CrearCertificacion()
    {
        try
        {
            var vm = new CertificacionViewModel();
            await CargarSelectsCertAsync(vm);
            return View(vm);
        }
        catch { TempData["Error"] = "No se pudo conectar a Supabase. Intenta de nuevo."; return RedirectToAction(nameof(Certificaciones)); }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CrearCertificacion(CertificacionViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            await CargarSelectsCertAsync(vm);
            return View(vm);
        }

        var cert = new CertificacionesSanitaria
        {
            IdCaballo = vm.IdCaballo,
            IdVeterinario = vm.IdVeterinario,
            IdEstadoCertificacion = vm.IdEstadoCertificacion,
            FechaEmision = vm.FechaEmision,
            FechaVencimiento = vm.FechaVencimiento,
            NumeroCertificado = vm.NumeroCertificado,
            Observaciones = vm.Observaciones
        };
        _ctx.CertificacionesSanitarias.Add(cert);
        await _ctx.SaveChangesAsync();

        TempData["Exito"] = "Certificación sanitaria registrada exitosamente.";
        return RedirectToAction(nameof(Certificaciones));
    }

    private async Task CargarSelectsAsync(HistorialVetViewModel vm)
    {
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Veterinarios = await _ctx.Veterinarios
            .Include(v => v.IdUsuarioNavigation)
            .Select(v => new SelectListItem(
                v.IdUsuarioNavigation.Nombre + " " + v.IdUsuarioNavigation.Apellido1,
                v.IdVeterinario.ToString()))
            .ToListAsync();

        vm.Certificaciones = await _ctx.CertificacionesSanitarias
            .Select(c => new SelectListItem(c.NumeroCertificado, c.IdCertificacion.ToString()))
            .ToListAsync();
    }

    private async Task CargarSelectsCertAsync(CertificacionViewModel vm)
    {
        vm.Caballos = await _ctx.Caballos
            .Where(c => c.Activo == true)
            .Select(c => new SelectListItem(c.Nombre + " (" + c.Codigo + ")", c.IdCaballo.ToString()))
            .ToListAsync();

        vm.Veterinarios = await _ctx.Veterinarios
            .Include(v => v.IdUsuarioNavigation)
            .Select(v => new SelectListItem(
                v.IdUsuarioNavigation.Nombre + " " + v.IdUsuarioNavigation.Apellido1,
                v.IdVeterinario.ToString()))
            .ToListAsync();

        vm.EstadosCertificacion = await _ctx.TcEstadoCertificacions
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoCertificacion.ToString()))
            .ToListAsync();
    }
}
