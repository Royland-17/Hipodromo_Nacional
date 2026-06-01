using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class CaballoService
{
    private readonly PostgresContext _ctx;

    public CaballoService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<CaballoListaViewModel>> ObtenerListaAsync()
    {
        return await _ctx.VwCaballosDetalles
            .Select(v => new CaballoListaViewModel
            {
                IdCaballo = v.IdCaballo ?? 0,
                Codigo = v.Codigo ?? "",
                Nombre = v.Caballo ?? "",
                EdadAnios = v.EdadAnios,
                PesoKg = v.PesoKg,
                Sexo = v.Sexo,
                Raza = v.Raza,
                EstadoSalud = v.EstadoSalud,
                Propietario = v.Propietario,
                CertVigente = v.CertVigente
            })
            .ToListAsync();
    }

    public async Task<Caballo?> ObtenerPorIdAsync(int id)
    {
        return await _ctx.Caballos.FindAsync(id);
    }

    public async Task CargarSelectsAsync(CaballoViewModel vm)
    {
        vm.Razas = await _ctx.TcRazas
            .Select(r => new SelectListItem(r.Descripcion, r.IdRaza.ToString()))
            .ToListAsync();

        vm.Sexos = await _ctx.TcSexos
            .Select(s => new SelectListItem(s.Descripcion, s.IdSexo.ToString()))
            .ToListAsync();

        vm.EstadosSalud = await _ctx.TcEstadoSaluds
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoSalud.ToString()))
            .ToListAsync();

        vm.Propietarios = await _ctx.Propietarios
            .Include(p => p.IdUsuarioNavigation)
            .Select(p => new SelectListItem(
                p.IdUsuarioNavigation.Nombre + " " + p.IdUsuarioNavigation.Apellido1,
                p.IdPropietario.ToString()))
            .ToListAsync();
    }

    public async Task<int> CrearAsync(CaballoViewModel vm)
    {
        var caballo = new Caballo
        {
            Codigo = vm.Codigo,
            Nombre = vm.Nombre,
            FechaNacimiento = vm.FechaNacimiento,
            PesoKg = vm.PesoKg,
            IdSexo = vm.IdSexo,
            IdRaza = vm.IdRaza,
            IdEstadoSalud = vm.IdEstadoSalud,
            IdPropietario = vm.IdPropietario,
            FechaRegistro = DateTime.Now,
            Activo = vm.Activo
        };
        _ctx.Caballos.Add(caballo);
        await _ctx.SaveChangesAsync();
        return caballo.IdCaballo;
    }

    public async Task EditarAsync(int id, CaballoViewModel vm)
    {
        var caballo = await _ctx.Caballos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        caballo.Codigo = vm.Codigo;
        caballo.Nombre = vm.Nombre;
        caballo.FechaNacimiento = vm.FechaNacimiento;
        caballo.PesoKg = vm.PesoKg;
        caballo.IdSexo = vm.IdSexo;
        caballo.IdRaza = vm.IdRaza;
        caballo.IdEstadoSalud = vm.IdEstadoSalud;
        caballo.IdPropietario = vm.IdPropietario;
        caballo.Activo = vm.Activo;

        await _ctx.SaveChangesAsync();
    }

    public async Task EliminarAsync(int id)
    {
        var caballo = await _ctx.Caballos.FindAsync(id)
            ?? throw new KeyNotFoundException();
        caballo.Activo = false;
        await _ctx.SaveChangesAsync();
    }
}
