using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class SuministroViewModel
{
    public int IdSuministro { get; set; }

    [Required(ErrorMessage = "El codigo es obligatorio")]
    [StringLength(30)]
    [Display(Name = "Codigo")]
    public string Codigo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Seleccione un tipo de suministro")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un tipo de suministro")]
    [Display(Name = "Tipo")]
    public int IdTipoSuministro { get; set; }

    [Required(ErrorMessage = "Seleccione un proveedor")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un proveedor")]
    [Display(Name = "Proveedor")]
    public int IdProveedor { get; set; }

    [Required(ErrorMessage = "Ingrese la cantidad disponible")]
    [Range(0.01, 9999999, ErrorMessage = "La cantidad debe ser mayor a 0")]
    [Display(Name = "Cantidad disponible")]
    public decimal CantidadDisponible { get; set; }

    [Required(ErrorMessage = "Ingrese la fecha de ingreso")]
    [Display(Name = "Fecha de ingreso")]
    [DataType(DataType.Date)]
    public DateOnly FechaIngreso { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    public IEnumerable<SelectListItem> TiposSuministro { get; set; } = [];
    public IEnumerable<SelectListItem> Proveedores { get; set; } = [];
}

public class SuministroListaViewModel
{
    public int IdSuministro { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string Proveedor { get; set; } = string.Empty;
    public decimal CantidadDisponible { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public bool Activo { get; set; }
}

public class AlimentacionViewModel
{
    [Required(ErrorMessage = "Seleccione un caballo")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un caballo")]
    [Display(Name = "Caballo")]
    public int IdCaballo { get; set; }

    [Required(ErrorMessage = "Seleccione un tipo de alimento")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un tipo de alimento")]
    [Display(Name = "Tipo de alimento")]
    public int IdTipoSuministro { get; set; }

    [Required(ErrorMessage = "Seleccione un alimento")]
    [Range(1, int.MaxValue, ErrorMessage = "Seleccione un alimento")]
    [Display(Name = "Alimento")]
    public int IdSuministro { get; set; }

    [Required(ErrorMessage = "Ingrese la fecha")]
    [Display(Name = "Fecha")]
    public DateTime FechaAlimentacion { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Ingrese la cantidad")]
    [Range(0.01, 999999, ErrorMessage = "La cantidad debe ser mayor a 0")]
    [Display(Name = "Cantidad")]
    public decimal Cantidad { get; set; }

    [Display(Name = "Observaciones")]
    [StringLength(255)]
    public string? Observaciones { get; set; }

    public IEnumerable<SelectListItem> Caballos { get; set; } = [];
    public IEnumerable<SelectListItem> TiposAlimento { get; set; } = [];
    public IEnumerable<SelectListItem> Alimentos { get; set; } = [];
}

public class AlimentacionListaViewModel
{
    public long IdAlimentacion { get; set; }
    public string Caballo { get; set; } = string.Empty;
    public string TipoAlimento { get; set; } = string.Empty;
    public string Alimento { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }
    public decimal Cantidad { get; set; }
}

public class AlimentacionFiltroViewModel
{
    [Display(Name = "Caballo")]
    public int? IdCaballo { get; set; }

    [Display(Name = "Tipo de alimento")]
    public int? IdTipoSuministro { get; set; }

    [Display(Name = "Desde")]
    public DateOnly? FechaDesde { get; set; }

    [Display(Name = "Hasta")]
    public DateOnly? FechaHasta { get; set; }

    public IEnumerable<SelectListItem> Caballos { get; set; } = [];
    public IEnumerable<SelectListItem> TiposAlimento { get; set; } = [];
}

public class AlimentacionIndexViewModel
{
    public AlimentacionFiltroViewModel Filtro { get; set; } = new();
    public List<AlimentacionListaViewModel> Registros { get; set; } = [];
}
