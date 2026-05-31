using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcEstadoAlertum
{
    public int IdEstadoAlerta { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Alerta> Alerta { get; set; } = new List<Alerta>();
}
