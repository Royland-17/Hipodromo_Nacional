using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class VwFacturasDetalle
{
    public int? IdFactura { get; set; }

    public string? NumeroFactura { get; set; }

    public DateTime? FechaFactura { get; set; }

    public string? Propietario { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? DescuentoPct { get; set; }

    public decimal? MontoDescuento { get; set; }

    public decimal? ImpuestoIva { get; set; }

    public decimal? ComisionAdmin { get; set; }

    public decimal? Total { get; set; }

    public string? EstadoPago { get; set; }
}
