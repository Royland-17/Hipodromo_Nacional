using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcEstadoEstablo
{
    public int IdEstadoEstablo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Establo> Establos { get; set; } = new List<Establo>();
}
