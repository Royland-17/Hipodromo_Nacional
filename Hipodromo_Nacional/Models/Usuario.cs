using System;
using System.Collections.Generic;

namespace Hipodromo_Nacional.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdRol { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido1 { get; set; } = null!;

    public string? Apellido2 { get; set; }

    public string Identificacion { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public bool? Activo { get; set; }

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

    public virtual ICollection<CorreosUsuario> CorreosUsuarios { get; set; } = new List<CorreosUsuario>();

    public virtual TcRolUsuario IdRolNavigation { get; set; } = null!;

    public virtual Propietario? Propietario { get; set; }

    public virtual ICollection<TelefonosUsuario> TelefonosUsuarios { get; set; } = new List<TelefonosUsuario>();

    public virtual Veterinario? Veterinario { get; set; }
}
