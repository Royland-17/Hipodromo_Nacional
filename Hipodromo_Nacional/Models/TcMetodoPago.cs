using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcMetodoPago
{
    public int IdMetodoPago { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<HistorialTransaccione> HistorialTransacciones { get; set; } = new List<HistorialTransaccione>();
}
