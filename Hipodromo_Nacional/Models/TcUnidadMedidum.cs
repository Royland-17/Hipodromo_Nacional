using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcUnidadMedidum
{
    public int IdUnidadMedida { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Simbolo { get; set; } = null!;

    public virtual ICollection<Suministro> Suministros { get; set; } = new List<Suministro>();
}
