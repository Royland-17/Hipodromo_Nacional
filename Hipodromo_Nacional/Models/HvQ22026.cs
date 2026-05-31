using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class HvQ22026
{
    public long IdHistorial { get; set; }

    public int IdCaballo { get; set; }

    public int IdVeterinario { get; set; }

    public int? IdCertificacion { get; set; }

    public DateTime FechaRevision { get; set; }

    public string Diagnostico { get; set; } = null!;

    public string? Tratamiento { get; set; }

    public string? Observaciones { get; set; }

    public DateOnly? ProximoControl { get; set; }

    public virtual Caballo IdCaballoNavigation { get; set; } = null!;

    public virtual CertificacionesSanitaria? IdCertificacionNavigation { get; set; }

    public virtual Veterinario IdVeterinarioNavigation { get; set; } = null!;
}
