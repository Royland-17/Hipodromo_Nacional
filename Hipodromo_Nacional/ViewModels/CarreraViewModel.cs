using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class CarreraViewModel
{
    public int IdEvento { get; set; }

    [Display(Name = "Código")]
    public string CodigoEvento { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha y hora son obligatorias")]
    [Display(Name = "Fecha y hora")]
    public DateTime FechaEvento { get; set; } = DateTime.Today.AddHours(14);

    [Required(ErrorMessage = "La distancia es obligatoria")]
    [Range(100, 10000, ErrorMessage = "La distancia debe estar entre 100 y 10000 metros")]
    [Display(Name = "Distancia (m)")]
    public int DistanciaMetros { get; set; }

    [Required(ErrorMessage = "El premio total es obligatorio")]
    [Range(0, 999999999999, ErrorMessage = "El premio total no puede ser negativo")]
    [Display(Name = "Premio total")]
    public decimal PremioTotal { get; set; }

    [Required(ErrorMessage = "El precio de inscripción es obligatorio")]
    [Range(0, 999999999, ErrorMessage = "El precio de inscripción no puede ser negativo")]
    [Display(Name = "Precio inscripción")]
    public decimal PrecioInscripcion { get; set; }

    [Required(ErrorMessage = "La comisión administrativa es obligatoria")]
    [Range(0, 100, ErrorMessage = "La comisión debe estar entre 0 y 100")]
    [Display(Name = "Comisión administrativa (%)")]
    public decimal ComisionAdmin { get; set; } = 5.00m;

    [Required]
    [Display(Name = "Tipo de carrera")]
    public int IdTipoCarrera { get; set; }

    [Required]
    [Display(Name = "Estado")]
    public int IdEstadoEvento { get; set; }

    [Display(Name = "Observaciones")]
    public string? Observaciones { get; set; }

    public IEnumerable<SelectListItem> TiposCarrera { get; set; } = [];
    public IEnumerable<SelectListItem> EstadosEvento { get; set; } = [];
}

public class CarreraListaViewModel
{
    public int IdEvento { get; set; }
    public string CodigoEvento { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public DateTime FechaEvento { get; set; }
    public int DistanciaMetros { get; set; }
    public decimal PremioTotal { get; set; }
    public decimal PrecioInscripcion { get; set; }
    public string TipoCarrera { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public int TotalInscritos { get; set; }
}

public class CarreraResumenViewModel
{
    public int IdEvento { get; set; }
    public string CodigoEvento { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public DateTime FechaEvento { get; set; }
    public string Estado { get; set; } = string.Empty;
}

public class InscripcionesCarreraViewModel
{
    public CarreraResumenViewModel Carrera { get; set; } = new();
    public List<InscripcionCarreraListaViewModel> Inscripciones { get; set; } = [];
}

public class InscripcionCarreraViewModel
{
    public int IdInscripcion { get; set; }

    [Required]
    public int IdEvento { get; set; }

    [Required]
    [Display(Name = "Caballo")]
    public int IdCaballo { get; set; }

    [Display(Name = "Posición de salida")]
    [Range(1, 99, ErrorMessage = "La posición de salida debe estar entre 1 y 99")]
    public int? PosicionSalida { get; set; }

    [Required]
    [Display(Name = "Estado")]
    public int IdEstadoInscripcion { get; set; }

    [Display(Name = "Observaciones")]
    [StringLength(255, ErrorMessage = "Las observaciones no pueden superar 255 caracteres")]
    public string? Observaciones { get; set; }

    public CarreraResumenViewModel Carrera { get; set; } = new();
    public IEnumerable<SelectListItem> Caballos { get; set; } = [];
    public IEnumerable<SelectListItem> EstadosInscripcion { get; set; } = [];
}

public class InscripcionCarreraListaViewModel
{
    public int IdInscripcion { get; set; }
    public int IdEvento { get; set; }
    public string Caballo { get; set; } = string.Empty;
    public string CodigoCaballo { get; set; } = string.Empty;
    public DateTime? FechaInscripcion { get; set; }
    public int? PosicionSalida { get; set; }
    public string Estado { get; set; } = string.Empty;
    public string? Observaciones { get; set; }
    public bool TieneResultado { get; set; }
}

public class ResultadosCarreraViewModel
{
    public CarreraResumenViewModel Carrera { get; set; } = new();
    public List<ResultadoCarreraListaViewModel> Resultados { get; set; } = [];
}

public class ResultadoCarreraViewModel
{
    public int IdResultado { get; set; }

    [Required]
    public int IdEvento { get; set; }

    [Required]
    public int IdInscripcion { get; set; }

    [Required(ErrorMessage = "La posición final es obligatoria")]
    [Range(1, 99, ErrorMessage = "La posición final debe estar entre 1 y 99")]
    [Display(Name = "Posición final")]
    public int PosicionFinal { get; set; }

    [Display(Name = "Tiempo (segundos)")]
    [Range(0, 99999, ErrorMessage = "El tiempo no puede ser negativo")]
    public decimal? TiempoSegundos { get; set; }

    [Display(Name = "Premio obtenido")]
    [Range(0, 999999999, ErrorMessage = "El premio obtenido no puede ser negativo")]
    public decimal? PremioObtenido { get; set; }

    [Display(Name = "Descalificado")]
    public bool Descalificado { get; set; }

    [Display(Name = "Motivo de descalificación")]
    [StringLength(255, ErrorMessage = "El motivo no puede superar 255 caracteres")]
    public string? MotivoDescalificacion { get; set; }

    public string Caballo { get; set; } = string.Empty;
    public string CodigoCaballo { get; set; } = string.Empty;
    public CarreraResumenViewModel Carrera { get; set; } = new();
}

public class ResultadoCarreraListaViewModel
{
    public int IdInscripcion { get; set; }
    public int? IdResultado { get; set; }
    public string Caballo { get; set; } = string.Empty;
    public string CodigoCaballo { get; set; } = string.Empty;
    public int? PosicionSalida { get; set; }
    public int? PosicionFinal { get; set; }
    public decimal? TiempoSegundos { get; set; }
    public decimal? PremioObtenido { get; set; }
    public bool Descalificado { get; set; }
    public string? MotivoDescalificacion { get; set; }
}
