using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class ResultadosService
{
    private readonly PostgresContext _ctx;

    public ResultadosService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<ResultadoPropietarioViewModel>> ObtenerPorUsuarioAsync(string usuarioLogin, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(usuarioLogin))
            return [];

        var usuario = await _ctx.Usuarios
            .AsNoTracking()
            .Where(u => u.Usuario1 == usuarioLogin)
            .Select(u => new { u.Nombre, u.Apellido1, u.Apellido2 })
            .FirstOrDefaultAsync(cancellationToken);

        if (usuario is null)
            return [];

        var nombre1 = string.Join(" ", new[] { usuario.Nombre, usuario.Apellido1 }
            .Where(x => !string.IsNullOrWhiteSpace(x)));
        var nombre2 = string.Join(" ", new[] { usuario.Nombre, usuario.Apellido1, usuario.Apellido2 }
            .Where(x => !string.IsNullOrWhiteSpace(x)));

        var resultados = await _ctx.VwResultadosEventos
            .AsNoTracking()
            .Where(r =>
                !string.IsNullOrWhiteSpace(r.Propietario)
                && (r.Propietario == nombre1 || r.Propietario == nombre2))
            .OrderByDescending(r => r.FechaEvento)
            .ThenBy(r => r.PosicionFinal)
            .Select(r => new ResultadoPropietarioViewModel
            {
                CodigoEvento = r.CodigoEvento ?? string.Empty,
                Evento = r.Evento ?? string.Empty,
                FechaEvento = r.FechaEvento,
                PosicionFinal = r.PosicionFinal,
                Caballo = r.Caballo ?? string.Empty,
                TiempoSegundos = r.TiempoSegundos,
                PremioObtenido = r.PremioObtenido,
                Descalificado = r.Descalificado ?? false
            })
            .ToListAsync(cancellationToken);

        return resultados;
    }
}
