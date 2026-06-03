namespace Hipodromo_Nacional.ViewModels;

public class UsuarioActualViewModel
{
    public int IdUsuario { get; set; }
    public string Usuario { get; set; } = string.Empty;
    public string NombreCompleto { get; set; } = string.Empty;
    public string Rol { get; set; } = string.Empty;
    public string Identificacion { get; set; } = string.Empty;
    public bool Activo { get; set; }
    public int? IdPropietario { get; set; }
    public int? IdVeterinario { get; set; }
}
