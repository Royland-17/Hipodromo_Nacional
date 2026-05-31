using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Veterinario
{
    public int IdVeterinario { get; set; }

    public int IdUsuario { get; set; }

    public string NumeroLicencia { get; set; } = null!;

    public string? Especialidad { get; set; }

    public string? NumeroColegio { get; set; }

    public virtual ICollection<CertificacionesSanitaria> CertificacionesSanitaria { get; set; } = new List<CertificacionesSanitaria>();

    public virtual ICollection<HvDefault> HvDefaults { get; set; } = new List<HvDefault>();

    public virtual ICollection<HvQ12025> HvQ12025s { get; set; } = new List<HvQ12025>();

    public virtual ICollection<HvQ12026> HvQ12026s { get; set; } = new List<HvQ12026>();

    public virtual ICollection<HvQ12027> HvQ12027s { get; set; } = new List<HvQ12027>();

    public virtual ICollection<HvQ12028> HvQ12028s { get; set; } = new List<HvQ12028>();

    public virtual ICollection<HvQ22025> HvQ22025s { get; set; } = new List<HvQ22025>();

    public virtual ICollection<HvQ22026> HvQ22026s { get; set; } = new List<HvQ22026>();

    public virtual ICollection<HvQ22027> HvQ22027s { get; set; } = new List<HvQ22027>();

    public virtual ICollection<HvQ22028> HvQ22028s { get; set; } = new List<HvQ22028>();

    public virtual ICollection<HvQ32025> HvQ32025s { get; set; } = new List<HvQ32025>();

    public virtual ICollection<HvQ32026> HvQ32026s { get; set; } = new List<HvQ32026>();

    public virtual ICollection<HvQ32027> HvQ32027s { get; set; } = new List<HvQ32027>();

    public virtual ICollection<HvQ32028> HvQ32028s { get; set; } = new List<HvQ32028>();

    public virtual ICollection<HvQ42025> HvQ42025s { get; set; } = new List<HvQ42025>();

    public virtual ICollection<HvQ42026> HvQ42026s { get; set; } = new List<HvQ42026>();

    public virtual ICollection<HvQ42027> HvQ42027s { get; set; } = new List<HvQ42027>();

    public virtual ICollection<HvQ42028> HvQ42028s { get; set; } = new List<HvQ42028>();

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
