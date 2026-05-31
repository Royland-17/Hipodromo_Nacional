using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcTipoCarrera
{
    public int IdTipoCarrera { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? DistanciaMinM { get; set; }

    public int? DistanciaMaxM { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
