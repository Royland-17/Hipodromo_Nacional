using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcRaza
{
    public int IdRaza { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Origen { get; set; }

    public virtual ICollection<Caballo> Caballos { get; set; } = new List<Caballo>();
}
