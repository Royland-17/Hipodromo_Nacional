namespace Hipodromo_Nacional.ViewModels;

public class ReporteResultadosViewModel
{
    public List<ResultadoEventoViewModel> Resultados { get; set; } = [];
    public List<RankingCaballoViewModel> Ranking { get; set; } = [];
    public List<string> Eventos { get; set; } = [];
    public string? EventoFiltro { get; set; }
}

public class ResultadoEventoViewModel
{
    public string CodigoEvento { get; set; } = string.Empty;
    public string Evento { get; set; } = string.Empty;
    public DateTime? FechaEvento { get; set; }
    public int? PosicionFinal { get; set; }
    public string Caballo { get; set; } = string.Empty;
    public string Propietario { get; set; } = string.Empty;
    public decimal? TiempoSegundos { get; set; }
    public decimal? PremioObtenido { get; set; }
    public bool? Descalificado { get; set; }
}

public class RankingCaballoViewModel
{
    public string Caballo { get; set; } = string.Empty;
    public string Propietario { get; set; } = string.Empty;
    public int Participaciones { get; set; }
    public int Victorias { get; set; }
    public int Podios { get; set; }
    public decimal PremiosAcumulados { get; set; }
}
