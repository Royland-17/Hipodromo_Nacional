using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public int IdPropietario { get; set; }

    public string NumeroFactura { get; set; } = null!;

    public DateTime? FechaFactura { get; set; }

    public decimal Subtotal { get; set; }

    public decimal DescuentoPct { get; set; }

    public decimal MontoDescuento { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal ImpuestoIva { get; set; }

    public decimal ComisionAdmin { get; set; }

    public decimal Total { get; set; }

    public int IdEstadoPago { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual ICollection<HistorialTransaccione> HistorialTransacciones { get; set; } = new List<HistorialTransaccione>();

    public virtual TcEstadoPago IdEstadoPagoNavigation { get; set; } = null!;

    public virtual Propietario IdPropietarioNavigation { get; set; } = null!;
}
