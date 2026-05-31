using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcSexo
{
    public int IdSexo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Caballo> Caballos { get; set; } = new List<Caballo>();
}
