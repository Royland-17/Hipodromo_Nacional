using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class VwEventosInscripcione
{
    public int? IdEvento { get; set; }

    public string? CodigoEvento { get; set; }

    public string? Evento { get; set; }

    public DateTime? FechaEvento { get; set; }

    public int? DistanciaMetros { get; set; }

    public decimal? PremioTotal { get; set; }

    public decimal? PrecioInscripcion { get; set; }

    public string? TipoCarrera { get; set; }

    public string? Estado { get; set; }

    public long? TotalInscritos { get; set; }
}
