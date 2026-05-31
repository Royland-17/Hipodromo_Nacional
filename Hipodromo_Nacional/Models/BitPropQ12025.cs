using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitPropQ12025
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdBarrio { get; set; }

    public bool? DescuentoProximaFactura { get; set; }
}
