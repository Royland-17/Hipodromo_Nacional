using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitCabQ12025
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? IdPropietario { get; set; }

    public int? IdRaza { get; set; }

    public int? IdEstadoSalud { get; set; }

    public decimal? PesoKg { get; set; }

    public bool? Activo { get; set; }
}
