using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hipodromo_Nacional.ViewModels;

public class PropietarioViewModel
{
    public int IdPropietario { get; set; }

    [Display(Name = "Usuario")]
    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    [StringLength(50)]
    public string Usuario { get; set; } = null!;

    [Display(Name = "Contraseña")]
    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [StringLength(200, MinimumLength = 6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
    [DataType(DataType.Password)]
    public string Contrasena { get; set; } = null!;

    [Display(Name = "Nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [Display(Name = "Primer apellido")]
    [Required(ErrorMessage = "El primer apellido es obligatorio.")]
    [StringLength(100)]
    public string Apellido1 { get; set; } = null!;

    [Display(Name = "Segundo apellido")]
    [StringLength(100)]
    public string? Apellido2 { get; set; }

    [Display(Name = "Identificación")]
    [Required(ErrorMessage = "La identificación es obligatoria.")]
    [StringLength(50)]
    public string Identificacion { get; set; } = null!;

    [Display(Name = "País")]
    [Required(ErrorMessage = "Seleccione un país.")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un país.")]
    public int IdPais { get; set; }

    [Display(Name = "Provincia")]
    [Required(ErrorMessage = "Seleccione una provincia.")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione una provincia.")]
    public int IdProvincia { get; set; }

    [Display(Name = "Cantón")]
    [Required(ErrorMessage = "Seleccione un cantón.")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un cantón.")]
    public int IdCanton { get; set; }

    [Display(Name = "Distrito")]
    [Required(ErrorMessage = "Seleccione un distrito.")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un distrito.")]
    public int IdDistrito { get; set; }

    [Display(Name = "Barrio")]
    [Required(ErrorMessage = "Seleccione un barrio.")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un barrio.")]
    public int IdBarrio { get; set; }

    [Display(Name = "Dirección exacta")]
    [StringLength(300)]
    public string? DireccionExacta { get; set; }

    public IEnumerable<SelectListItem> Paises { get; set; } = [];
    public IEnumerable<SelectListItem> Provincias { get; set; } = [];
    public IEnumerable<SelectListItem> Cantones { get; set; } = [];
    public IEnumerable<SelectListItem> Distritos { get; set; } = [];
    public IEnumerable<SelectListItem> Barrios { get; set; } = [];
}

public class PropietarioEditViewModel : PropietarioViewModel
{
    [Display(Name = "Contraseña (dejar vacío para no cambiar)")]
    [StringLength(200, MinimumLength = 6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
    [DataType(DataType.Password)]
    public new string? Contrasena { get; set; }

    public int IdUsuario { get; set; }
}