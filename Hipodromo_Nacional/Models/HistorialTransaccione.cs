using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class HistorialTransaccione
{
    public int IdTransaccion { get; set; }

    public int IdFactura { get; set; }

    public int IdMetodoPago { get; set; }

    public DateTime? FechaPago { get; set; }

    public decimal Monto { get; set; }

    public string? Referencia { get; set; }

    public string? Observaciones { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual TcMetodoPago IdMetodoPagoNavigation { get; set; } = null!;
}
