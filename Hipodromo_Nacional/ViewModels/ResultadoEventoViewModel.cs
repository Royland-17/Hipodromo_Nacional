namespace Hipodromo_Nacional.ViewModels;

public class ResultadoPropietarioViewModel
{
    public string CodigoEvento { get; set; } = string.Empty;
    public string Evento { get; set; } = string.Empty;
    public DateTime? FechaEvento { get; set; }
    public int? PosicionFinal { get; set; }
    public string Caballo { get; set; } = string.Empty;
    public decimal? TiempoSegundos { get; set; }
    public decimal? PremioObtenido { get; set; }
    public bool Descalificado { get; set; }
}
