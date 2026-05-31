using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Pai
{
    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoIso { get; set; }

    public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();
}
