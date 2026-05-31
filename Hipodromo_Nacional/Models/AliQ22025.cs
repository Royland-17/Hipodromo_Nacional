using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class AliQ22025
{
    public long IdAlimentacion { get; set; }

    public int IdCaballo { get; set; }

    public int IdSuministro { get; set; }

    public int IdUsuarioRegistro { get; set; }

    public DateTime FechaAlimentacion { get; set; }

    public decimal Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public bool? Activo { get; set; }

    public virtual Caballo IdCaballoNavigation { get; set; } = null!;

    public virtual Suministro IdSuministroNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioRegistroNavigation { get; set; } = null!;
}
