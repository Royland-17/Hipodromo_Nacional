using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitInsQ32026
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdEvento { get; set; }

    public int? IdCaballo { get; set; }

    public int? IdEstadoInscripcion { get; set; }

    public int? PosicionSalida { get; set; }
}
