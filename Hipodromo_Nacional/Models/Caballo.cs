using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Caballo
{
    public int IdCaballo { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public decimal PesoKg { get; set; }

    public int IdSexo { get; set; }

    public int IdRaza { get; set; }

    public int IdEstadoSalud { get; set; }

    public int IdPropietario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Alerta> Alerta { get; set; } = new List<Alerta>();

    public virtual ICollection<AliDefault> AliDefaults { get; set; } = new List<AliDefault>();

    public virtual ICollection<AliQ12025> AliQ12025s { get; set; } = new List<AliQ12025>();

    public virtual ICollection<AliQ12026> AliQ12026s { get; set; } = new List<AliQ12026>();

    public virtual ICollection<AliQ12027> AliQ12027s { get; set; } = new List<AliQ12027>();

    public virtual ICollection<AliQ12028> AliQ12028s { get; set; } = new List<AliQ12028>();

    public virtual ICollection<AliQ22025> AliQ22025s { get; set; } = new List<AliQ22025>();

    public virtual ICollection<AliQ22026> AliQ22026s { get; set; } = new List<AliQ22026>();

    public virtual ICollection<AliQ22027> AliQ22027s { get; set; } = new List<AliQ22027>();

    public virtual ICollection<AliQ22028> AliQ22028s { get; set; } = new List<AliQ22028>();

    public virtual ICollection<AliQ32025> AliQ32025s { get; set; } = new List<AliQ32025>();

    public virtual ICollection<AliQ32026> AliQ32026s { get; set; } = new List<AliQ32026>();

    public virtual ICollection<AliQ32027> AliQ32027s { get; set; } = new List<AliQ32027>();

    public virtual ICollection<AliQ32028> AliQ32028s { get; set; } = new List<AliQ32028>();

    public virtual ICollection<AliQ42025> AliQ42025s { get; set; } = new List<AliQ42025>();

    public virtual ICollection<AliQ42026> AliQ42026s { get; set; } = new List<AliQ42026>();

    public virtual ICollection<AliQ42027> AliQ42027s { get; set; } = new List<AliQ42027>();

    public virtual ICollection<AliQ42028> AliQ42028s { get; set; } = new List<AliQ42028>();

    public virtual ICollection<AsignacionesEstablo> AsignacionesEstablos { get; set; } = new List<AsignacionesEstablo>();

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

    public virtual TcEstadoSalud IdEstadoSaludNavigation { get; set; } = null!;

    public virtual Propietario IdPropietarioNavigation { get; set; } = null!;

    public virtual TcRaza IdRazaNavigation { get; set; } = null!;

    public virtual TcSexo IdSexoNavigation { get; set; } = null!;

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
