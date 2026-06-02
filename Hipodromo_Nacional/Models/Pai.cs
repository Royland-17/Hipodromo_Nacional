using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.Models;

public partial class Pai
{
    public int IdPais { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
    public string Nombre { get; set; } = null!;

    [StringLength(2, ErrorMessage = "El codigo ISO no puede exceder 2 caracteres.")]
    public string? CodigoIso { get; set; }

    public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();
}
