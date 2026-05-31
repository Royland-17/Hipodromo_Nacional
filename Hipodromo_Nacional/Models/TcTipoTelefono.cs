using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcTipoTelefono
{
    public int IdTipoTelefono { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<TelefonosUsuario> TelefonosUsuarios { get; set; } = new List<TelefonosUsuario>();
}
