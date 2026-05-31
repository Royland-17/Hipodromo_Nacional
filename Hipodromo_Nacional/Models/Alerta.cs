using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Alerta
{
    public int IdAlerta { get; set; }

    public int IdPropietario { get; set; }

    public int? IdCaballo { get; set; }

    public int IdTipoAlerta { get; set; }

    public int IdEstadoAlerta { get; set; }

    public string Mensaje { get; set; } = null!;

    public DateTime? FechaGeneracion { get; set; }

    public DateTime? FechaLectura { get; set; }

    public virtual Caballo? IdCaballoNavigation { get; set; }

    public virtual TcEstadoAlertum IdEstadoAlertaNavigation { get; set; } = null!;

    public virtual Propietario IdPropietarioNavigation { get; set; } = null!;

    public virtual TcTipoAlertum IdTipoAlertaNavigation { get; set; } = null!;
}
