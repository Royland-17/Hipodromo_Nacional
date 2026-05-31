using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class AsignacionesEstablo
{
    public int IdAsignacion { get; set; }

    public int IdCaballo { get; set; }

    public int IdEstablo { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public DateOnly? FechaSalida { get; set; }

    public bool? Activa { get; set; }

    public string? Observaciones { get; set; }

    public virtual Caballo IdCaballoNavigation { get; set; } = null!;

    public virtual Establo IdEstabloNavigation { get; set; } = null!;
}
