using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Establo
{
    public int IdEstablo { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    public int Capacidad { get; set; }

    public int IdEstadoEstablo { get; set; }

    public virtual ICollection<AsignacionesEstablo> AsignacionesEstablos { get; set; } = new List<AsignacionesEstablo>();

    public virtual TcEstadoEstablo IdEstadoEstabloNavigation { get; set; } = null!;
}
