using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitAsigQ42025
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdCaballo { get; set; }

    public int? IdEstablo { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public DateOnly? FechaSalida { get; set; }

    public bool? Activa { get; set; }

    public string? Observaciones { get; set; }
}
