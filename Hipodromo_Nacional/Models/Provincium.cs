using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Provincium
{
    public int IdProvincia { get; set; }

    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Canton> Cantons { get; set; } = new List<Canton>();

    public virtual Pai IdPaisNavigation { get; set; } = null!;
}
