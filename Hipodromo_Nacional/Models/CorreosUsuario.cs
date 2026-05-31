using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class CorreosUsuario
{
    public int IdCorreo { get; set; }

    public int IdUsuario { get; set; }

    public int IdTipoCorreo { get; set; }

    public string Correo { get; set; } = null!;

    public virtual TcTipoCorreo IdTipoCorreoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
