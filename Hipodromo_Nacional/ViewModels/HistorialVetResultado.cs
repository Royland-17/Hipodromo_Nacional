namespace Hipodromo_Nacional.ViewModels;

public class HistorialVetResultado
{
    public long IdHistorial { get; set; }
    public int IdCaballo { get; set; }
    public int IdVeterinario { get; set; }
    public int? IdCertificacion { get; set; }
    public DateTime FechaRevision { get; set; }
    public string Diagnostico { get; set; } = string.Empty;
    public string? Tratamiento { get; set; }
    public string? Observaciones { get; set; }
    public DateOnly? ProximoControl { get; set; }
    public string? NombreCaballo { get; set; }
    public string? NombreVeterinario { get; set; }
}
