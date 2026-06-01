using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class EstabloViewModel
{
    public int IdEstablo { get; set; }

    [Required(ErrorMessage = "El código es obligatorio")]
    [Display(Name = "Código")]
    public string Codigo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La ubicación es obligatoria")]
    [Display(Name = "Ubicación")]
    public string Ubicacion { get; set; } = string.Empty;

    [Required(ErrorMessage = "La capacidad es obligatoria")]
    [Range(1, 500, ErrorMessage = "La capacidad debe ser entre 1 y 500")]
    [Display(Name = "Capacidad")]
    public int Capacidad { get; set; }

    [Required]
    [Display(Name = "Estado")]
    public int IdEstadoEstablo { get; set; }

    public IEnumerable<SelectListItem> EstadosEstablo { get; set; } = [];

    public int CaballosAsignados { get; set; }
    public int EspaciosDisponibles => Capacidad - CaballosAsignados;
}

public class AsignacionViewModel
{
    public int IdAsignacion { get; set; }

    [Required]
    [Display(Name = "Caballo")]
    public int IdCaballo { get; set; }

    [Required]
    [Display(Name = "Establo")]
    public int IdEstablo { get; set; }

    [Required]
    [Display(Name = "Fecha de Ingreso")]
    public DateOnly FechaIngreso { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    [Display(Name = "Fecha de Salida")]
    public DateOnly? FechaSalida { get; set; }

    [Display(Name = "Observaciones")]
    public string? Observaciones { get; set; }

    public bool Activa { get; set; } = true;

    public IEnumerable<SelectListItem> Caballos { get; set; } = [];
    public IEnumerable<SelectListItem> Establos { get; set; } = [];

    public string? NombreCaballo { get; set; }
    public string? NombreEstablo { get; set; }
}
