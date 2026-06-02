namespace Hipodromo_Nacional.Hipodromo.BL;

public sealed record SelectOptionDto(int Value, string Text);
public sealed record DeleteOutcomeDto(bool NotFound, bool Succeeded, bool AlreadyApplied);

public class PropietarioCreateDto
{
    public int IdPropietario { get; set; }
    public string Usuario { get; set; } = null!;
    public string Contrasena { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public string Apellido1 { get; set; } = null!;
    public string? Apellido2 { get; set; }
    public string Identificacion { get; set; } = null!;

    public int IdPais { get; set; }
    public int IdProvincia { get; set; }
    public int IdCanton { get; set; }
    public int IdDistrito { get; set; }
    public int IdBarrio { get; set; }
    public string? DireccionExacta { get; set; }

    public IReadOnlyList<SelectOptionDto> Paises { get; set; } = [];
    public IReadOnlyList<SelectOptionDto> Provincias { get; set; } = [];
    public IReadOnlyList<SelectOptionDto> Cantones { get; set; } = [];
    public IReadOnlyList<SelectOptionDto> Distritos { get; set; } = [];
    public IReadOnlyList<SelectOptionDto> Barrios { get; set; } = [];
}

public class PropietarioEditDto : PropietarioCreateDto
{
    public int IdUsuario { get; set; }
    public new string? Contrasena { get; set; }
}