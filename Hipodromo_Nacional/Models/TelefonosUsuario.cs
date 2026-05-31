using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TelefonosUsuario
{
    public int IdTelefono { get; set; }

    public int IdUsuario { get; set; }

    public int IdTipoTelefono { get; set; }

    public string Numero { get; set; } = null!;

    public virtual TcTipoTelefono IdTipoTelefonoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
