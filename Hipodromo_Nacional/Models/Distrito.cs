using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Distrito
{
    public int IdDistrito { get; set; }

    public int IdCanton { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Barrio> Barrios { get; set; } = new List<Barrio>();

    public virtual Canton IdCantonNavigation { get; set; } = null!;
}
