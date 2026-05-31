using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class VwResultadosEvento
{
    public string? CodigoEvento { get; set; }

    public string? Evento { get; set; }

    public DateTime? FechaEvento { get; set; }

    public int? PosicionFinal { get; set; }

    public string? Caballo { get; set; }

    public string? Propietario { get; set; }

    public decimal? TiempoSegundos { get; set; }

    public decimal? PremioObtenido { get; set; }

    public bool? Descalificado { get; set; }
}
