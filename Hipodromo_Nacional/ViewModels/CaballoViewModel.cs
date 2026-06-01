using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class CaballoViewModel
{
    public int IdCaballo { get; set; }

    [Required(ErrorMessage = "El código es obligatorio")]
    [Display(Name = "Código")]
    public string Codigo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
    [Display(Name = "Fecha de Nacimiento")]
    public DateOnly FechaNacimiento { get; set; }

    [Required(ErrorMessage = "El peso es obligatorio")]
    [Range(50, 1200, ErrorMessage = "El peso debe estar entre 50 y 1200 kg")]
    [Display(Name = "Peso (kg)")]
    public decimal PesoKg { get; set; }

    [Required]
    [Display(Name = "Sexo")]
    public int IdSexo { get; set; }

    [Required]
    [Display(Name = "Raza")]
    public int IdRaza { get; set; }

    [Required]
    [Display(Name = "Estado de Salud")]
    public int IdEstadoSalud { get; set; }

    [Required]
    [Display(Name = "Propietario")]
    public int IdPropietario { get; set; }

    public bool Activo { get; set; } = true;

    public IEnumerable<SelectListItem> Sexos { get; set; } = [];
    public IEnumerable<SelectListItem> Razas { get; set; } = [];
    public IEnumerable<SelectListItem> EstadosSalud { get; set; } = [];
    public IEnumerable<SelectListItem> Propietarios { get; set; } = [];
}

public class CaballoListaViewModel
{
    public int IdCaballo { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public int? EdadAnios { get; set; }
    public decimal? PesoKg { get; set; }
    public string? Sexo { get; set; }
    public string? Raza { get; set; }
    public string? EstadoSalud { get; set; }
    public string? Propietario { get; set; }
    public bool? CertVigente { get; set; }
}
