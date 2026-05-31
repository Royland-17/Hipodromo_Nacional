using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcEstadoPago
{
    public int IdEstadoPago { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
