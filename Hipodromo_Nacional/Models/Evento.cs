using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Evento
{
    public int IdEvento { get; set; }

    public string CodigoEvento { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime FechaEvento { get; set; }

    public int DistanciaMetros { get; set; }

    public decimal PremioTotal { get; set; }

    public decimal PrecioInscripcion { get; set; }

    public decimal ComisionAdmin { get; set; }

    public int IdTipoCarrera { get; set; }

    public int IdEstadoEvento { get; set; }

    public string? Observaciones { get; set; }

    public virtual TcEstadoEvento IdEstadoEventoNavigation { get; set; } = null!;

    public virtual TcTipoCarrera IdTipoCarreraNavigation { get; set; } = null!;

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
