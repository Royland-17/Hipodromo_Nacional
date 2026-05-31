using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitAlertQ32025
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdPropietario { get; set; }

    public int? IdCaballo { get; set; }

    public int? IdTipoAlerta { get; set; }

    public int? IdEstadoAlerta { get; set; }

    public string? Mensaje { get; set; }
}
