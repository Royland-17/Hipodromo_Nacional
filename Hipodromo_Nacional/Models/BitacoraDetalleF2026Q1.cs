using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitacoraDetalleF2026Q1
{
    public int IdBitacora { get; set; }

    public int? IdDetalle { get; set; }

    public int? IdFactura { get; set; }

    public int? IdInscripcion { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public int? Cantidad { get; set; }

    public decimal? SubtotalLinea { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }
}
