using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcTipoCorreo
{
    public int IdTipoCorreo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CorreosUsuario> CorreosUsuarios { get; set; } = new List<CorreosUsuario>();
}
