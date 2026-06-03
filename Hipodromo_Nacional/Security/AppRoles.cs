namespace Hipodromo_Nacional.Security;

public static class AppRoles
{
    public const string Administrador = "Administrador";
    public const string Propietario = "Propietario";
    public const string Veterinario = "Veterinario";
    public const string EncargadoDeEstablo = "Encargado de Establo";

    public static bool EsPermitido(string? rol)
    {
        return rol == Administrador
            || rol == Propietario
            || rol == Veterinario
            || rol == EncargadoDeEstablo;
    }
}
