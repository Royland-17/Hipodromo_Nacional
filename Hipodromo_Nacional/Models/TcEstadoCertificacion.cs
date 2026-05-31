using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class TcEstadoCertificacion
{
    public int IdEstadoCertificacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CertificacionesSanitaria> CertificacionesSanitaria { get; set; } = new List<CertificacionesSanitaria>();
}
