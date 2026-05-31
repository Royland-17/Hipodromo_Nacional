using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class VwCaballosDetalle
{
    public int? IdCaballo { get; set; }

    public string? Codigo { get; set; }

    public string? Caballo { get; set; }

    public int? EdadAnios { get; set; }

    public decimal? PesoKg { get; set; }

    public string? Sexo { get; set; }

    public string? Raza { get; set; }

    public string? EstadoSalud { get; set; }

    public string? Propietario { get; set; }

    public bool? CertVigente { get; set; }
}
