using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Barrio
{
    public int IdBarrio { get; set; }

    public int IdDistrito { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Distrito IdDistritoNavigation { get; set; } = null!;

    public virtual ICollection<Propietario> Propietarios { get; set; } = new List<Propietario>();
}
