using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class ResultadosCarrera
{
    public int IdResultado { get; set; }

    public int IdInscripcion { get; set; }

    public int PosicionFinal { get; set; }

    public decimal? TiempoSegundos { get; set; }

    public decimal? PremioObtenido { get; set; }

    public bool? Descalificado { get; set; }

    public string? MotivoDescalificacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Inscripcione IdInscripcionNavigation { get; set; } = null!;
}
