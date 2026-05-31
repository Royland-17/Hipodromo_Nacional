using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Canton
{
    public int IdCanton { get; set; }

    public int IdProvincia { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Distrito> Distritos { get; set; } = new List<Distrito>();

    public virtual Provincium IdProvinciaNavigation { get; set; } = null!;
}
