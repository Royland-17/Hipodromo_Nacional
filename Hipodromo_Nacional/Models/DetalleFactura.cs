using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class DetalleFactura
{
    public int IdDetalle { get; set; }

    public int IdFactura { get; set; }

    public int IdInscripcion { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public decimal SubtotalLinea { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Inscripcione IdInscripcionNavigation { get; set; } = null!;
}
