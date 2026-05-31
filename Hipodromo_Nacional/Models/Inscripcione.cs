using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Inscripcione
{
    public int IdInscripcion { get; set; }

    public int IdEvento { get; set; }

    public int IdCaballo { get; set; }

    public DateTime? FechaInscripcion { get; set; }

    public int? PosicionSalida { get; set; }

    public int IdEstadoInscripcion { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Caballo IdCaballoNavigation { get; set; } = null!;

    public virtual TcEstadoInscripcion IdEstadoInscripcionNavigation { get; set; } = null!;

    public virtual Evento IdEventoNavigation { get; set; } = null!;

    public virtual ResultadosCarrera? ResultadosCarrera { get; set; }
}
