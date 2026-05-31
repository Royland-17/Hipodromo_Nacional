using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class VwAlertasPendiente
{
    public int? IdAlerta { get; set; }

    public string? Propietario { get; set; }

    public string? Caballo { get; set; }

    public string? TipoAlerta { get; set; }

    public string? Mensaje { get; set; }

    public DateTime? FechaGeneracion { get; set; }
}
