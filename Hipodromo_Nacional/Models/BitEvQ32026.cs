using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitEvQ32026
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? CodigoEvento { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaEvento { get; set; }

    public decimal? PremioTotal { get; set; }

    public int? IdTipoCarrera { get; set; }

    public int? IdEstadoEvento { get; set; }
}
