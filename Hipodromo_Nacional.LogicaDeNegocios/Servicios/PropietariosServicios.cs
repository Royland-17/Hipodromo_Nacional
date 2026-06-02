using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.LogicaDeNegocios.DTOs.DTOsPropietarios;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Hipodromo_Nacional.LogicaDeNegocios.Services;

public sealed class PropietariosServicios : IPropietariosServicios
{
    private readonly PostgresContext _db;
    private readonly IMemoryCache _cache;
    private readonly ILogger<PropietariosServicios> _logger;

    public PropietariosServicios(PostgresContext db, IMemoryCache cache, ILogger<PropietariosServicios> logger)
    {
        _db = db;
        _cache = cache;
        _logger = logger;
    }

    public async Task<IReadOnlyList<Propietario>> BuscarPorIdentificacionAsync(string? identificacion)
    {
        if (string.IsNullOrWhiteSpace(identificacion)) return [];

        var identificacionNormalizada = identificacion.Trim();

        var item = await _db.Propietarios
            .AsNoTracking()
            .Include(p => p.IdUsuarioNavigation)
            .Include(p => p.IdBarrioNavigation)
                .ThenInclude(b => b.IdDistritoNavigation)
                    .ThenInclude(d => d.IdCantonNavigation)
                        .ThenInclude(c => c.IdProvinciaNavigation)
                            .ThenInclude(pr => pr.IdPaisNavigation)
            .FirstOrDefaultAsync(p => p.IdUsuarioNavigation.Identificacion == identificacionNormalizada);

        if (item is null) return [];
        return [item];
    }

    public Task<Propietario?> ObtenerDetalleAsync(int id) =>
        _db.Propietarios
            .AsNoTracking()
            .Include(p => p.IdUsuarioNavigation)
            .Include(p => p.IdBarrioNavigation)
                .ThenInclude(b => b.IdDistritoNavigation)
                    .ThenInclude(d => d.IdCantonNavigation)
                        .ThenInclude(c => c.IdProvinciaNavigation)
                            .ThenInclude(pr => pr.IdPaisNavigation)
            .FirstOrDefaultAsync(p => p.IdPropietario == id);

    public async Task<PropietarioCreateDto> ObtenerCreateDtoAsync()
    {
        var dto = new PropietarioCreateDto();
        return await RecargarDropdownsCreateAsync(dto);
    }

    public async Task<PropietarioCreateDto> RecargarDropdownsCreateAsync(PropietarioCreateDto dto)
    {
        dto.Paises = await ObtenerPaisesAsync();
        dto.Provincias = dto.IdPais > 0 ? await ObtenerProvinciasAsync(dto.IdPais) : [];
        dto.Cantones = dto.IdProvincia > 0 ? await ObtenerCantonesAsync(dto.IdProvincia) : [];
        dto.Distritos = dto.IdCanton > 0 ? await ObtenerDistritosAsync(dto.IdCanton) : [];
        dto.Barrios = dto.IdDistrito > 0 ? await ObtenerBarriosAsync(dto.IdDistrito) : [];
        return dto;
    }

    public async Task CrearAsync(PropietarioCreateDto dto)
    {
        var totalTimer = Stopwatch.StartNew();

        _logger.LogInformation("Inicio CrearAsync para usuario {Usuario}", dto.Usuario);

        var precheckTimer = Stopwatch.StartNew();
        var existeDuplicado = await _db.Usuarios
            .AsNoTracking()
            .AnyAsync(u => u.Usuario1 == dto.Usuario || u.Identificacion == dto.Identificacion);
        precheckTimer.Stop();

        _logger.LogInformation("Pre-check duplicados completado en {ElapsedMs} ms para usuario {Usuario}", precheckTimer.ElapsedMilliseconds, dto.Usuario);

        if (existeDuplicado)
            throw new DbUpdateException("El usuario o la identificación ya existen.");

        var previousTimeout = _db.Database.GetCommandTimeout();
        _db.Database.SetCommandTimeout(90);

        try
        {
            try
            {
                var spUsuarioTimer = Stopwatch.StartNew();
                await _db.Database.ExecuteSqlInterpolatedAsync($"""
                    CALL public.sp_insert_usuario(
                        {2},
                        {dto.Usuario},
                        {dto.Contrasena},
                        {dto.Nombre},
                        {dto.Apellido1},
                        {dto.Apellido2},
                        {dto.Identificacion}
                    )
                    """);
                spUsuarioTimer.Stop();
                _logger.LogInformation("sp_insert_usuario completado en {ElapsedMs} ms para usuario {Usuario}", spUsuarioTimer.ElapsedMilliseconds, dto.Usuario);
            }
            catch (Exception ex) when (IsTransient(ex) || ex is TimeoutException)
            {
                _logger.LogWarning(ex, "sp_insert_usuario lanzó error transitorio para usuario {Usuario}. Verificando si inserción se completó.", dto.Usuario);

                // If the call timed out but the user was actually created, continue safely.
                var existsAfterTimeout = await _db.Usuarios
                    .AsNoTracking()
                    .AnyAsync(u => u.Usuario1 == dto.Usuario);

                if (!existsAfterTimeout)
                    throw;

                _logger.LogWarning("sp_insert_usuario reportó timeout/error, pero usuario {Usuario} existe en DB; se continúa con inserción de propietario.", dto.Usuario);
            }

            var selectUsuarioTimer = Stopwatch.StartNew();
            var idUsuario = await _db.Usuarios
                .AsNoTracking()
                .Where(u => u.Usuario1 == dto.Usuario)
                .Select(u => u.IdUsuario)
                .SingleOrDefaultAsync();
            selectUsuarioTimer.Stop();

            _logger.LogInformation("Lookup de IdUsuario completado en {ElapsedMs} ms para usuario {Usuario}", selectUsuarioTimer.ElapsedMilliseconds, dto.Usuario);

            if (idUsuario <= 0)
                throw new InvalidOperationException("No fue posible obtener el usuario creado.");

            var spPropietarioTimer = Stopwatch.StartNew();
            await _db.Database.ExecuteSqlInterpolatedAsync($"""
                CALL public.sp_insert_propietario(
                    {idUsuario},
                    {dto.IdBarrio},
                    {dto.DireccionExacta}
                )
                """);
            spPropietarioTimer.Stop();

            _logger.LogInformation("sp_insert_propietario completado en {ElapsedMs} ms para usuario {Usuario} (idUsuario {IdUsuario})", spPropietarioTimer.ElapsedMilliseconds, dto.Usuario, idUsuario);
        }
        finally
        {
            totalTimer.Stop();
            _db.Database.SetCommandTimeout(previousTimeout);
            _logger.LogInformation("CrearAsync finalizó en {ElapsedMs} ms para usuario {Usuario}", totalTimer.ElapsedMilliseconds, dto.Usuario);
        }
    }

    public async Task<PropietarioEditDto?> ObtenerEditDtoAsync(int id)
    {
        var previousTimeout = _db.Database.GetCommandTimeout();
        _db.Database.SetCommandTimeout(20);

        try
        {
        var p = await _db.Propietarios
            .AsNoTracking()
            .Include(x => x.IdUsuarioNavigation)
            .Include(x => x.IdBarrioNavigation)
                .ThenInclude(b => b.IdDistritoNavigation)
                    .ThenInclude(d => d.IdCantonNavigation)
                        .ThenInclude(c => c.IdProvinciaNavigation)
                            .ThenInclude(pr => pr.IdPaisNavigation)
            .FirstOrDefaultAsync(x => x.IdPropietario == id);

        if (p is null) return null;

        var dto = new PropietarioEditDto
        {
            IdPropietario = p.IdPropietario,
            IdUsuario = p.IdUsuario,
            Usuario = p.IdUsuarioNavigation.Usuario1,
            Nombre = p.IdUsuarioNavigation.Nombre,
            Apellido1 = p.IdUsuarioNavigation.Apellido1,
            Apellido2 = p.IdUsuarioNavigation.Apellido2,
            Identificacion = p.IdUsuarioNavigation.Identificacion,
            IdBarrio = p.IdBarrio,
            IdDistrito = p.IdBarrioNavigation.IdDistrito,
            IdCanton = p.IdBarrioNavigation.IdDistritoNavigation.IdCanton,
            IdProvincia = p.IdBarrioNavigation.IdDistritoNavigation.IdCantonNavigation.IdProvincia,
            IdPais = p.IdBarrioNavigation.IdDistritoNavigation.IdCantonNavigation.IdProvinciaNavigation.IdPais,
            DireccionExacta = p.DireccionExacta
        };

            _db.Database.SetCommandTimeout(8);

            try
            {
                return await RecargarDropdownsEditAsync(dto);
            }
            catch (Exception ex) when (ex is TimeoutException || IsTransient(ex))
            {
                _logger.LogWarning(ex, "Recarga de catálogos en Edit tardó demasiado para propietario {IdPropietario}; se usa fallback mínimo.", id);
                CargarOpcionesMinimas(dto, p);
                return dto;
            }
        }
        finally
        {
            _db.Database.SetCommandTimeout(previousTimeout);
        }
    }

    public async Task<PropietarioEditDto> RecargarDropdownsEditAsync(PropietarioEditDto dto)
    {
        dto.Paises = await ObtenerPaisesAsync();
        dto.Provincias = dto.IdPais > 0 ? await ObtenerProvinciasAsync(dto.IdPais) : [];
        dto.Cantones = dto.IdProvincia > 0 ? await ObtenerCantonesAsync(dto.IdProvincia) : [];
        dto.Distritos = dto.IdCanton > 0 ? await ObtenerDistritosAsync(dto.IdCanton) : [];
        dto.Barrios = dto.IdDistrito > 0 ? await ObtenerBarriosAsync(dto.IdDistrito) : [];
        return dto;
    }

    public async Task<bool> ActualizarAsync(int id, PropietarioEditDto dto)
    {
        var strategy = _db.Database.CreateExecutionStrategy();
        var updated = false;

        await strategy.ExecuteAsync(async () =>
        {
            var previousTimeout = _db.Database.GetCommandTimeout();
            _db.Database.SetCommandTimeout(180);

            await using var tx = await _db.Database.BeginTransactionAsync();

            try
            {
                var propietario = await _db.Propietarios
                    .AsNoTracking()
                    .Where(x => x.IdPropietario == id)
                    .Select(x => new
                    {
                        x.IdPropietario,
                        x.IdUsuario,
                        Descuento = x.DescuentoProximaFactura ?? false
                    })
                    .FirstOrDefaultAsync();

                if (propietario is null)
                {
                    updated = false;
                    return;
                }

                await _db.Database.ExecuteSqlInterpolatedAsync($"""
                    CALL public.sp_update_usuario(
                        {propietario.IdUsuario},
                        {dto.Nombre},
                        {dto.Apellido1},
                        {dto.Apellido2},
                        {true}
                    )
                    """);

                await _db.Usuarios
                    .Where(u => u.IdUsuario == propietario.IdUsuario)
                    .ExecuteUpdateAsync(setters => setters
                        .SetProperty(u => u.Usuario1, dto.Usuario)
                        .SetProperty(u => u.Identificacion, dto.Identificacion));

                if (!string.IsNullOrWhiteSpace(dto.Contrasena))
                {
                    await _db.Usuarios
                        .Where(u => u.IdUsuario == propietario.IdUsuario)
                        .ExecuteUpdateAsync(setters => setters
                            .SetProperty(u => u.Contrasena, dto.Contrasena));
                }

                await _db.Database.ExecuteSqlInterpolatedAsync($"""
                    CALL public.sp_update_propietario(
                        {dto.IdPropietario},
                        {dto.IdBarrio},
                        {dto.DireccionExacta},
                        {propietario.Descuento}
                    )
                    """);

                await tx.CommitAsync();
                updated = true;
            }
            finally
            {
                _db.Database.SetCommandTimeout(previousTimeout);
            }
        });

        return updated;
    }

    public Task<Propietario?> ObtenerDeleteVmAsync(int id) =>
        _db.Propietarios
            .AsNoTracking()
            .Include(p => p.IdUsuarioNavigation)
            .Include(p => p.IdBarrioNavigation)
                .ThenInclude(b => b.IdDistritoNavigation)
                    .ThenInclude(d => d.IdCantonNavigation)
                        .ThenInclude(c => c.IdProvinciaNavigation)
                            .ThenInclude(pr => pr.IdPaisNavigation)
            .FirstOrDefaultAsync(p => p.IdPropietario == id);

    public async Task<DeleteOutcomeDto> DesactivarAsync(int id)
    {
        var propietario = await _db.Propietarios
            .AsNoTracking()
            .Where(p => p.IdPropietario == id)
            .Select(p => new { p.IdPropietario })
            .FirstOrDefaultAsync();

        if (propietario is null) return new DeleteOutcomeDto(true, false, false);

        try
        {
            _db.Database.SetCommandTimeout(15);
            await _db.Database.ExecuteSqlInterpolatedAsync($"CALL public.sp_delete_propietario({id})");
            return new DeleteOutcomeDto(false, true, false);
        }
        catch (Exception ex) when (IsTransient(ex) || ex is TimeoutException)
        {
            if (await PropietarioYaDesactivado(id))
                return new DeleteOutcomeDto(false, true, true);

            throw;
        }
        finally
        {
            _db.Database.SetCommandTimeout((int?)null);
        }
    }

    public async Task<IReadOnlyList<SelectOptionDto>> ObtenerProvinciasAsync(int idPais)
    {
        if (idPais <= 0) return [];

        var items = await _cache.GetOrCreateAsync($"geo:prov:{idPais}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20);
            return await _db.Provincia
                .AsNoTracking()
                .Where(p => p.IdPais == idPais)
                .OrderBy(p => p.Nombre)
                .Select(p => new SelectOptionDto(p.IdProvincia, p.Nombre))
                .ToListAsync();
        });

        if (items is { Count: > 0 })
            return items;

        var fallback = await _cache.GetOrCreateAsync("geo:prov:all", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            return await _db.Provincia
                .AsNoTracking()
                .OrderBy(p => p.Nombre)
                .Select(p => new SelectOptionDto(p.IdProvincia, p.Nombre))
                .ToListAsync();
        });

        return fallback ?? [];
    }

    public async Task<IReadOnlyList<SelectOptionDto>> ObtenerCantonesAsync(int idProvincia)
    {
        if (idProvincia <= 0) return [];

        var items = await _cache.GetOrCreateAsync($"geo:can:{idProvincia}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20);
            return await _db.Cantons
                .AsNoTracking()
                .Where(c => c.IdProvincia == idProvincia)
                .OrderBy(c => c.Nombre)
                .Select(c => new SelectOptionDto(c.IdCanton, c.Nombre))
                .ToListAsync();
        });

        if (items is { Count: > 0 })
            return items;

        // Fallback for sparse/incomplete catalog data by province.
        var fallback = await _cache.GetOrCreateAsync("geo:can:all", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            return await _db.Cantons
                .AsNoTracking()
                .OrderBy(c => c.Nombre)
                .Select(c => new SelectOptionDto(c.IdCanton, c.Nombre))
                .ToListAsync();
        });

        return fallback ?? [];
    }

    public async Task<IReadOnlyList<SelectOptionDto>> ObtenerDistritosAsync(int idCanton)
    {
        if (idCanton <= 0) return [];

        var items = await _cache.GetOrCreateAsync($"geo:dis:{idCanton}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20);
            return await _db.Distritos
                .AsNoTracking()
                .Where(d => d.IdCanton == idCanton)
                .OrderBy(d => d.Nombre)
                .Select(d => new SelectOptionDto(d.IdDistrito, d.Nombre))
                .ToListAsync();
        });

        if (items is { Count: > 0 })
            return items;

        var fallback = await _cache.GetOrCreateAsync("geo:dis:all", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            return await _db.Distritos
                .AsNoTracking()
                .OrderBy(d => d.Nombre)
                .Select(d => new SelectOptionDto(d.IdDistrito, d.Nombre))
                .ToListAsync();
        });

        return fallback ?? [];
    }

    public async Task<IReadOnlyList<SelectOptionDto>> ObtenerBarriosAsync(int idDistrito)
    {
        if (idDistrito <= 0) return [];

        var items = await _cache.GetOrCreateAsync($"geo:bar:{idDistrito}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20);
            return await _db.Barrios
                .AsNoTracking()
                .Where(b => b.IdDistrito == idDistrito)
                .OrderBy(b => b.Nombre)
                .Select(b => new SelectOptionDto(b.IdBarrio, b.Nombre))
                .ToListAsync();
        });

        if (items is { Count: > 0 })
            return items;

        var fallback = await _cache.GetOrCreateAsync("geo:bar:all", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            return await _db.Barrios
                .AsNoTracking()
                .OrderBy(b => b.Nombre)
                .Select(b => new SelectOptionDto(b.IdBarrio, b.Nombre))
                .ToListAsync();
        });

        return fallback ?? [];
    }

    private async Task<IReadOnlyList<SelectOptionDto>> ObtenerPaisesAsync()
    {
        var items = await _cache.GetOrCreateAsync("geo:pais", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20);
            return await _db.Pais
                .AsNoTracking()
                .Where(p => _db.Provincia.Any(pr => pr.IdPais == p.IdPais))
                .OrderBy(p => p.Nombre)
                .Select(p => new SelectOptionDto(p.IdPais, p.Nombre))
                .ToListAsync();
        });

        return items ?? [];
    }

    private async Task<bool> PropietarioYaDesactivado(int idPropietario)
    {
        var estado = await _db.Propietarios
            .AsNoTracking()
            .Where(p => p.IdPropietario == idPropietario)
            .Select(p => new { Activo = p.IdUsuarioNavigation.Activo })
            .FirstOrDefaultAsync();

        return estado?.Activo == false;
    }

    private static void CargarOpcionesMinimas(PropietarioEditDto dto, Propietario p)
    {
        var barrio = p.IdBarrioNavigation;
        var distrito = barrio?.IdDistritoNavigation;
        var canton = distrito?.IdCantonNavigation;
        var provincia = canton?.IdProvinciaNavigation;
        var pais = provincia?.IdPaisNavigation;

        dto.Paises = CrearOpcionUnica(dto.IdPais, pais?.Nombre);
        dto.Provincias = CrearOpcionUnica(dto.IdProvincia, provincia?.Nombre);
        dto.Cantones = CrearOpcionUnica(dto.IdCanton, canton?.Nombre);
        dto.Distritos = CrearOpcionUnica(dto.IdDistrito, distrito?.Nombre);
        dto.Barrios = CrearOpcionUnica(dto.IdBarrio, barrio?.Nombre);
    }

    private static IReadOnlyList<SelectOptionDto> CrearOpcionUnica(int value, string? text)
    {
        if (value <= 0 || string.IsNullOrWhiteSpace(text))
            return [];

        return [new SelectOptionDto(value, text)];
    }

    private static bool IsTransient(Exception ex)
    {
        for (Exception? current = ex; current is not null; current = current.InnerException)
        {
            if (current is TimeoutException)
                return true;

            var message = current.Message;
            if (message.Contains("timeout", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("timed out", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("connection", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("transient failure", StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }
}
