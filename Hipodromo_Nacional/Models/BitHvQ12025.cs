using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitHvQ12025
{
    public long IdBitacora { get; set; }

    public long? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int? IdCaballo { get; set; }

    public int? IdVeterinario { get; set; }

    public DateTime? FechaRevision { get; set; }

    public string? Diagnostico { get; set; }

    public string? Tratamiento { get; set; }

    public DateOnly? ProximoControl { get; set; }
}
