using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Npgsql;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class CaballoService
{
    private readonly PostgresContext _ctx;

    public CaballoService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<CaballoListaViewModel>> ObtenerListaAsync(string usuarioLogin, bool esAdministrador)
    {
        var query = _ctx.VwCaballosDetalles.AsQueryable();

        if (!esAdministrador)
        {
            var idPropietario = await ObtenerIdPropietarioPorUsuarioAsync(usuarioLogin);
            if (idPropietario is null)
                return [];

            var idsCaballosPropietario = await _ctx.Caballos
                .Where(c => c.IdPropietario == idPropietario.Value)
                .Select(c => c.IdCaballo)
                .ToListAsync();

            query = query.Where(v => v.IdCaballo.HasValue && idsCaballosPropietario.Contains(v.IdCaballo.Value));
        }

        return await query
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

    public async Task<int?> ObtenerIdPropietarioPorUsuarioAsync(string usuarioLogin)
    {
        if (string.IsNullOrWhiteSpace(usuarioLogin))
            return null;

        return await _ctx.Usuarios
            .Where(u => u.Usuario1 == usuarioLogin)
            .Select(u => u.Propietario != null ? (int?)u.Propietario.IdPropietario : null)
            .FirstOrDefaultAsync();
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

    public async Task<string> GenerarCodigoAutomaticoAsync()
    {
        for (var intento = 0; intento < 5; intento++)
        {
            var codigo = $"CAB-{DateTime.UtcNow:yyyyMMddHHmmssfff}-{Random.Shared.Next(100, 999)}";

            var existe = await _ctx.Caballos
                .AsNoTracking()
                .AnyAsync(c => c.Codigo == codigo);

            if (!existe)
                return codigo;
        }

        var token = Guid.NewGuid().ToString("N")[..12].ToUpperInvariant();
        return $"CAB-{token}";
    }

    public async Task<int> CrearAsync(CaballoViewModel vm, int idPropietario)
    {
        var codigo = await GenerarCodigoAutomaticoAsync();

        var caballo = new Caballo
        {
            Codigo = codigo,
            Nombre = vm.Nombre,
            FechaNacimiento = vm.FechaNacimiento,
            PesoKg = vm.PesoKg,
            IdSexo = vm.IdSexo,
            IdRaza = vm.IdRaza,
            IdEstadoSalud = vm.IdEstadoSalud,
            IdPropietario = idPropietario,
            FechaRegistro = DateTime.Now,
            Activo = vm.Activo
        };
        _ctx.Caballos.Add(caballo);

        try
        {
            await _ctx.SaveChangesAsync();
        }
        catch (DbUpdateException ex) when (EsCodigoCaballoDuplicado(ex))
        {
            throw new InvalidOperationException("Ya existe un caballo con ese codigo.", ex);
        }

        return caballo.IdCaballo;
    }

    private static bool EsCodigoCaballoDuplicado(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "caballos_codigo_key", StringComparison.OrdinalIgnoreCase);
    }

    public async Task EditarAsync(int id, CaballoViewModel vm, int idPropietario)
    {
        var caballo = await _ctx.Caballos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        if (caballo.IdPropietario != idPropietario)
            throw new UnauthorizedAccessException();

        caballo.Nombre = vm.Nombre;
        caballo.FechaNacimiento = vm.FechaNacimiento;
        caballo.PesoKg = vm.PesoKg;
        caballo.IdSexo = vm.IdSexo;
        caballo.IdRaza = vm.IdRaza;
        caballo.IdEstadoSalud = vm.IdEstadoSalud;
        caballo.Activo = vm.Activo;

        try
        {
            await _ctx.SaveChangesAsync();
        }
        catch (DbUpdateException ex) when (EsCodigoCaballoDuplicado(ex))
        {
            throw new InvalidOperationException("Ya existe un caballo con ese codigo.", ex);
        }
    }

    public async Task EliminarAsync(int id, int idPropietario)
    {
        var caballo = await _ctx.Caballos.FindAsync(id)
            ?? throw new KeyNotFoundException();

        if (caballo.IdPropietario != idPropietario)
            throw new UnauthorizedAccessException();

        caballo.Activo = false;
        await _ctx.SaveChangesAsync();
    }
}
