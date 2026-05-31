using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class VwPropietariosFrecuente
{
    public int? IdPropietario { get; set; }

    public string? Propietario { get; set; }

    public string? Identificacion { get; set; }

    public decimal? TotalFacturado6m { get; set; }

    public bool? DescuentoProximaFactura { get; set; }

    public DateTime? FechaUltimaRevisionDescuento { get; set; }
}
