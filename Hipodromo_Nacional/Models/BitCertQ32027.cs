using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitCertQ32027
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdCaballo { get; set; }

    public string? NumeroCertificado { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public int? IdEstadoCertificacion { get; set; }
}
