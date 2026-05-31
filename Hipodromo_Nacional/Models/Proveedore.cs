using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Contacto { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Suministro> Suministros { get; set; } = new List<Suministro>();
}
