using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcRolUsuario
{
    public int IdRol { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool? Activo { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
