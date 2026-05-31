using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitFacQ42026
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? NumeroFactura { get; set; }

    public int? IdPropietario { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Total { get; set; }

    public int? IdEstadoPago { get; set; }

    public decimal? DescuentoPct { get; set; }
}
