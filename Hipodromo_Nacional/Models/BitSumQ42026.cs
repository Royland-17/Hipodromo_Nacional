using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitSumQ42026
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? IdTipoSuministro { get; set; }

    public int? IdProveedor { get; set; }

    public decimal? CantidadDisponible { get; set; }

    public bool? Activo { get; set; }
}
