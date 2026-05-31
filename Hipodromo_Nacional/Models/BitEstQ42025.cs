using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitEstQ42025
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Ubicacion { get; set; }

    public int? Capacidad { get; set; }

    public int? IdEstadoEstablo { get; set; }
}
