using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Propietario
{
    public int IdPropietario { get; set; }

    public int IdUsuario { get; set; }

    public int IdBarrio { get; set; }

    public string? DireccionExacta { get; set; }

    public bool? DescuentoProximaFactura { get; set; }

    public DateTime? FechaUltimaRevisionDescuento { get; set; }

    public virtual ICollection<Alerta> Alerta { get; set; } = new List<Alerta>();

    public virtual ICollection<Caballo> Caballos { get; set; } = new List<Caballo>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Barrio IdBarrioNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
