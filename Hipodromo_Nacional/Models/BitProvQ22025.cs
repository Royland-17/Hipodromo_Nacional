using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class BitProvQ22025
{
    public long IdBitacora { get; set; }

    public int? IdRegistro { get; set; }

    public string UsuarioBd { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Contacto { get; set; }

    public bool? Activo { get; set; }
}
