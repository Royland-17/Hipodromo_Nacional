using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitAliQ22025
{
    public long IdBitacora { get; set; }

    public long? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdCaballo { get; set; }

    public int? IdSuministro { get; set; }

    public DateTime? FechaAlimentacion { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Observaciones { get; set; }
}
