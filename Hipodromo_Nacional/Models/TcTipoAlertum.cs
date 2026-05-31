using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcTipoAlertum
{
    public int IdTipoAlerta { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Alerta> Alerta { get; set; } = new List<Alerta>();
}
