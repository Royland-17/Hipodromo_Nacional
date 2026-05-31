using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitResQ32027
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdInscripcion { get; set; }

    public int? PosicionFinal { get; set; }

    public decimal? TiempoSegundos { get; set; }

    public decimal? PremioObtenido { get; set; }

    public bool? Descalificado { get; set; }
}
