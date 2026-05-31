using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcTipoSuministro
{
    public int IdTipoSuministro { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Suministro> Suministros { get; set; } = new List<Suministro>();
}
