using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcEstadoEvento
{
    public int IdEstadoEvento { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
