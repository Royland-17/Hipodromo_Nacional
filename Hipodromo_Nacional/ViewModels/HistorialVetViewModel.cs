using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class HistorialVetViewModel
{
    public long IdHistorial { get; set; }

    [Required]
    [Display(Name = "Caballo")]
    public int IdCaballo { get; set; }

    [Required]
    [Display(Name = "Veterinario")]
    public int IdVeterinario { get; set; }

    [Display(Name = "Certificación Sanitaria")]
    public int? IdCertificacion { get; set; }

    [Required]
    [Display(Name = "Fecha de Revisión")]
    public DateTime FechaRevision { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El diagnóstico es obligatorio")]
    [Display(Name = "Diagnóstico")]
    public string Diagnostico { get; set; } = string.Empty;

    [Display(Name = "Tratamiento")]
    public string? Tratamiento { get; set; }

    [Display(Name = "Observaciones")]
    public string? Observaciones { get; set; }

    [Display(Name = "Próximo Control")]
    public DateOnly? ProximoControl { get; set; }

    public IEnumerable<SelectListItem> Caballos { get; set; } = [];
    public IEnumerable<SelectListItem> Veterinarios { get; set; } = [];
    public IEnumerable<SelectListItem> Certificaciones { get; set; } = [];

    public string? NombreCaballo { get; set; }
    public string? NombreVeterinario { get; set; }
}

public class CertificacionViewModel : IValidatableObject
{
    public int IdCertificacion { get; set; }

    [Required]
    [Display(Name = "Caballo")]
    public int IdCaballo { get; set; }

    [Required]
    [Display(Name = "Veterinario")]
    public int IdVeterinario { get; set; }

    [Required]
    [Display(Name = "Estado")]
    public int IdEstadoCertificacion { get; set; }

    [Required]
    [Display(Name = "Fecha de Emisión")]
    public DateOnly FechaEmision { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    [Required]
    [Display(Name = "Fecha de Vencimiento")]
    public DateOnly FechaVencimiento { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext ctx)
    {
        if (FechaVencimiento <= FechaEmision)
            yield return new ValidationResult(
                "La fecha de vencimiento debe ser posterior a la fecha de emisión.",
                new[] { nameof(FechaVencimiento) });
    }

    [Required(ErrorMessage = "El número de certificado es obligatorio")]
    [Display(Name = "N° Certificado")]
    public string NumeroCertificado { get; set; } = string.Empty;

    [Display(Name = "Observaciones")]
    public string? Observaciones { get; set; }

    public IEnumerable<SelectListItem> Caballos { get; set; } = [];
    public IEnumerable<SelectListItem> Veterinarios { get; set; } = [];
    public IEnumerable<SelectListItem> EstadosCertificacion { get; set; } = [];

    public string? NombreCaballo { get; set; }
    public string? NombreVeterinario { get; set; }
    public string? EstadoCertificacion { get; set; }
}
