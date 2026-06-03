using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class InscripcionesEventoPageViewModel
{
    public List<EventoDisponibleViewModel> EventosDisponibles { get; set; } = [];
    public List<CaballoPropietarioOptionViewModel> CaballosDisponibles { get; set; } = [];
    public List<InscripcionPropietarioListaViewModel> MisInscripciones { get; set; } = [];
}

public class EventoDisponibleViewModel
{
    public int IdEvento { get; set; }
    public string CodigoEvento { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public DateTime FechaEvento { get; set; }
    public string Estado { get; set; } = string.Empty;
    public decimal PrecioInscripcion { get; set; }
    public int TotalInscritos { get; set; }
}

public class CaballoPropietarioOptionViewModel
{
    public int IdCaballo { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
}

public class InscripcionPropietarioListaViewModel
{
    public int IdInscripcion { get; set; }
    public string CodigoEvento { get; set; } = string.Empty;
    public string Evento { get; set; } = string.Empty;
    public DateTime? FechaEvento { get; set; }
    public string Caballo { get; set; } = string.Empty;
    public DateTime? FechaInscripcion { get; set; }
    public string EstadoInscripcion { get; set; } = string.Empty;
    public int? PosicionSalida { get; set; }
}

public class InscribirEventoInputViewModel
{
    [Required]
    public int IdEvento { get; set; }

    [Required(ErrorMessage = "Selecciona un caballo para inscribir")]
    public int IdCaballo { get; set; }

    [StringLength(255, ErrorMessage = "Las observaciones no pueden superar 255 caracteres")]
    public string? Observaciones { get; set; }
}
