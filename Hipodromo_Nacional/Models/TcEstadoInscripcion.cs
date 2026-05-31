using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcEstadoInscripcion
{
    public int IdEstadoInscripcion { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
