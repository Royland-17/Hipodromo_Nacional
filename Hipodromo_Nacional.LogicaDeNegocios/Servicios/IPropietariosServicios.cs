using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.LogicaDeNegocios.DTOs.DTOsPropietarios;

namespace Hipodromo_Nacional.LogicaDeNegocios.Services;

public interface IPropietariosServicios
{
    Task<IReadOnlyList<Propietario>> BuscarPorIdentificacionAsync(string? identificacion);
    Task<Propietario?> ObtenerDetalleAsync(int id);

    Task<PropietarioCreateDto> ObtenerCreateDtoAsync();
    Task<PropietarioCreateDto> RecargarDropdownsCreateAsync(PropietarioCreateDto dto);
    Task CrearAsync(PropietarioCreateDto dto);

    Task<PropietarioEditDto?> ObtenerEditDtoAsync(int id);
    Task<PropietarioEditDto> RecargarDropdownsEditAsync(PropietarioEditDto dto);
    Task<bool> ActualizarAsync(int id, PropietarioEditDto dto);

    Task<Propietario?> ObtenerDeleteVmAsync(int id);
    Task<DeleteOutcomeDto> DesactivarAsync(int id);

    Task<IReadOnlyList<SelectOptionDto>> ObtenerProvinciasAsync(int idPais);
    Task<IReadOnlyList<SelectOptionDto>> ObtenerCantonesAsync(int idProvincia);
    Task<IReadOnlyList<SelectOptionDto>> ObtenerDistritosAsync(int idCanton);
    Task<IReadOnlyList<SelectOptionDto>> ObtenerBarriosAsync(int idDistrito);
}