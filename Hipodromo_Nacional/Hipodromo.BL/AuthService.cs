using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.Security;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class AuthService
{
    private readonly PostgresContext _ctx;

    public AuthService(PostgresContext ctx) => _ctx = ctx;

    public async Task<UsuarioAutenticadoDto?> AutenticarAsync(string nombreUsuario, string contrasena)
    {
        if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            return null;

        var login = nombreUsuario.Trim();

        var usuarioDb = await _ctx.Usuarios
            .AsNoTracking()
            .Include(u => u.IdRolNavigation)
            .FirstOrDefaultAsync(u =>
                (u.Activo ?? true)
                && (u.IdRolNavigation.Activo ?? true)
                && u.Usuario1 == login);

        if (usuarioDb is null)
            return null;

        if (!string.Equals(usuarioDb.Contrasena, contrasena, StringComparison.Ordinal))
            return null;

        var rol = usuarioDb.IdRolNavigation.Descripcion?.Trim();
        if (!AppRoles.EsPermitido(rol))
            return null;

        return new UsuarioAutenticadoDto
        {
            IdUsuario = usuarioDb.IdUsuario,
            Usuario = usuarioDb.Usuario1,
            NombreCompleto = ArmarNombre(usuarioDb),
            Rol = rol!
        };
    }

    private static string ArmarNombre(Usuario usuario)
    {
        var partes = new[] { usuario.Nombre, usuario.Apellido1, usuario.Apellido2 }
            .Where(x => !string.IsNullOrWhiteSpace(x));

        return string.Join(" ", partes);
    }
}

public sealed class UsuarioAutenticadoDto
{
    public int IdUsuario { get; init; }
    public string Usuario { get; init; } = string.Empty;
    public string NombreCompleto { get; init; } = string.Empty;
    public string Rol { get; init; } = string.Empty;
}
