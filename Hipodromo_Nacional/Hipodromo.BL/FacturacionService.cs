using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;
using Npgsql;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class FacturacionService
{
    private readonly PostgresContext _ctx;

    public FacturacionService(PostgresContext ctx) => _ctx = ctx;

    public async Task<int?> ObtenerIdPropietarioPorUsuarioAsync(string usuarioLogin)
    {
        if (string.IsNullOrWhiteSpace(usuarioLogin))
            return null;

        return await _ctx.Usuarios
            .Where(u => u.Usuario1 == usuarioLogin)
            .Select(u => u.Propietario != null ? (int?)u.Propietario.IdPropietario : null)
            .FirstOrDefaultAsync();
    }

    public async Task<List<FacturaListViewModel>> ObtenerListaAsync(int? idPropietario)
    {
        var query = _ctx.Facturas
            .Include(f => f.IdPropietarioNavigation).ThenInclude(p => p.IdUsuarioNavigation)
            .Include(f => f.IdEstadoPagoNavigation)
            .AsQueryable();

        if (idPropietario is not null)
            query = query.Where(f => f.IdPropietario == idPropietario.Value);

        return await query
            .OrderByDescending(f => f.FechaFactura)
            .Select(f => new FacturaListViewModel
            {
                IdFactura      = f.IdFactura,
                NumeroFactura  = f.NumeroFactura,
                FechaFactura   = f.FechaFactura,
                Propietario    = f.IdPropietarioNavigation.IdUsuarioNavigation.Nombre + " " + f.IdPropietarioNavigation.IdUsuarioNavigation.Apellido1,
                Subtotal       = f.Subtotal,
                DescuentoPct   = f.DescuentoPct,
                MontoDescuento = f.MontoDescuento,
                ImpuestoIva    = f.ImpuestoIva,
                ComisionAdmin  = f.ComisionAdmin,
                Total          = f.Total,
                EstadoPago     = f.IdEstadoPagoNavigation.Descripcion,
                IdEstadoPago   = f.IdEstadoPago
            })
            .ToListAsync();
    }

    public async Task<FacturaDetalleViewModel?> ObtenerDetalleAsync(int id, int? idPropietario)
    {
        var query = _ctx.Facturas
            .Include(f => f.IdPropietarioNavigation).ThenInclude(p => p.IdUsuarioNavigation)
            .Include(f => f.IdEstadoPagoNavigation)
            .Include(f => f.DetalleFacturas)
                .ThenInclude(d => d.IdInscripcionNavigation)
                    .ThenInclude(i => i.IdEventoNavigation)
            .Include(f => f.DetalleFacturas)
                .ThenInclude(d => d.IdInscripcionNavigation)
                    .ThenInclude(i => i.IdCaballoNavigation)
            .Include(f => f.HistorialTransacciones)
                .ThenInclude(t => t.IdMetodoPagoNavigation)
            .Where(f => f.IdFactura == id)
            .AsQueryable();

        if (idPropietario is not null)
            query = query.Where(f => f.IdPropietario == idPropietario.Value);

        var f = await query.FirstOrDefaultAsync();

        if (f is null) return null;

        return new FacturaDetalleViewModel
        {
            IdFactura      = f.IdFactura,
            NumeroFactura  = f.NumeroFactura,
            FechaFactura   = f.FechaFactura,
            Propietario    = f.IdPropietarioNavigation.IdUsuarioNavigation.Nombre + " " + f.IdPropietarioNavigation.IdUsuarioNavigation.Apellido1,
            Subtotal       = f.Subtotal,
            DescuentoPct   = f.DescuentoPct,
            MontoDescuento = f.MontoDescuento,
            BaseImponible  = f.BaseImponible,
            ImpuestoIva    = f.ImpuestoIva,
            ComisionAdmin  = f.ComisionAdmin,
            Total          = f.Total,
            EstadoPago     = f.IdEstadoPagoNavigation.Descripcion,
            IdEstadoPago   = f.IdEstadoPago,
            Detalles = f.DetalleFacturas.Select(d => new DetalleFacturaViewModel
            {
                IdDetalle        = d.IdDetalle,
                Evento           = d.IdInscripcionNavigation.IdEventoNavigation.Nombre,
                Caballo          = d.IdInscripcionNavigation.IdCaballoNavigation.Nombre,
                FechaInscripcion = d.IdInscripcionNavigation.FechaInscripcion,
                PrecioUnitario   = d.PrecioUnitario,
                Cantidad         = d.Cantidad,
                SubtotalLinea    = d.SubtotalLinea
            }).ToList(),
            Transacciones = f.HistorialTransacciones.OrderByDescending(t => t.FechaPago).Select(t => new TransaccionViewModel
            {
                IdTransaccion = t.IdTransaccion,
                IdFactura     = t.IdFactura,
                FechaPago     = t.FechaPago,
                Monto         = t.Monto,
                MetodoPago    = t.IdMetodoPagoNavigation.Descripcion,
                Referencia    = t.Referencia,
                Observaciones = t.Observaciones
            }).ToList()
        };
    }

    public async Task CargarSelectsCrearAsync(CrearFacturaViewModel vm)
    {
        await EjecutarEvaluacionPropietariosFrecuentesAsync();

        vm.EstadosPago = await _ctx.TcEstadoPagos
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoPago.ToString()))
            .ToListAsync();

        vm.InscripcionesDisponibles = await _ctx.Inscripciones
            .Include(i => i.IdEventoNavigation)
            .Include(i => i.IdCaballoNavigation)
            .ThenInclude(c => c.IdPropietarioNavigation)
            .ThenInclude(p => p.IdUsuarioNavigation)
            .Where(i => !_ctx.DetalleFacturas.Any(d => d.IdInscripcion == i.IdInscripcion))
            .Select(i => new InscripcionSelectViewModel
            {
                IdInscripcion    = i.IdInscripcion,
                IdPropietario    = i.IdCaballoNavigation.IdPropietario,
                Propietario      = i.IdCaballoNavigation.IdPropietarioNavigation.IdUsuarioNavigation.Nombre + " "
                                  + i.IdCaballoNavigation.IdPropietarioNavigation.IdUsuarioNavigation.Apellido1,
                Evento           = i.IdEventoNavigation.Nombre,
                Caballo          = i.IdCaballoNavigation.Nombre,
                FechaInscripcion = i.FechaInscripcion,
                PrecioUnitario   = i.IdEventoNavigation.PrecioInscripcion
            })
            .ToListAsync();

        vm.Propietarios = await _ctx.Propietarios
            .Include(p => p.IdUsuarioNavigation)
            .OrderBy(p => p.IdUsuarioNavigation.Nombre)
            .Select(p => new SelectListItem(
                p.IdUsuarioNavigation.Nombre + " " + p.IdUsuarioNavigation.Apellido1,
                p.IdPropietario.ToString()))
            .ToListAsync();
    }

    public async Task CrearAsync(CrearFacturaViewModel vm)
    {
        await EjecutarEvaluacionPropietariosFrecuentesAsync();

        var inscripciones = await _ctx.Inscripciones
            .Include(i => i.IdEventoNavigation)
            .Include(i => i.IdCaballoNavigation)
            .Where(i => vm.InscripcionesSeleccionadas.Contains(i.IdInscripcion))
            .ToListAsync();

        var idsSeleccionadosUnicos = vm.InscripcionesSeleccionadas.Distinct().Count();
        if (inscripciones.Count != idsSeleccionadosUnicos)
        {
            throw new InvalidOperationException("Algunas inscripciones seleccionadas no estan disponibles para facturacion.");
        }

        var propietariosSeleccionados = inscripciones
            .Select(i => i.IdCaballoNavigation.IdPropietario)
            .Distinct()
            .ToList();

        if (propietariosSeleccionados.Count != 1)
        {
            throw new InvalidOperationException("Solo puedes facturar inscripciones de caballos del propietario seleccionado.");
        }

        var idPropietarioFactura = propietariosSeleccionados[0];

        if (vm.IdPropietario > 0 && vm.IdPropietario != idPropietarioFactura)
        {
            throw new InvalidOperationException("Solo puedes facturar inscripciones de caballos del propietario seleccionado.");
        }

        var aplicarDescuentoAutomatico = await DebeAplicarseDescuentoAutomaticoAsync(idPropietarioFactura);
        var descuentoPct = aplicarDescuentoAutomatico ? 10m : 0m;

        var subtotal = inscripciones.Sum(i => i.IdEventoNavigation.PrecioInscripcion);
        var montoDescuento = Math.Round(subtotal * descuentoPct / 100, 2);
        var baseImponible = subtotal - montoDescuento;
        var iva = Math.Round(baseImponible * 0.13m, 2);
        var comision = inscripciones.Sum(i => i.IdEventoNavigation.ComisionAdmin);
        var total = baseImponible + iva + comision;

        await using var tx = await _ctx.Database.BeginTransactionAsync();

        try
        {
            var numeroFactura = await GenerarNumeroFacturaAsync();

            var factura = new Factura
            {
                IdPropietario  = idPropietarioFactura,
                NumeroFactura  = numeroFactura,
                FechaFactura   = vm.FechaFactura,
                Subtotal       = subtotal,
                DescuentoPct   = descuentoPct,
                MontoDescuento = montoDescuento,
                BaseImponible  = baseImponible,
                ImpuestoIva    = iva,
                ComisionAdmin  = comision,
                Total          = total,
                IdEstadoPago   = vm.IdEstadoPago
            };

            _ctx.Facturas.Add(factura);
            try
            {
                await _ctx.SaveChangesAsync();
            }
            catch (DbUpdateException ex) when (EsViolacionPkFacturas(ex))
            {
                await SincronizarSecuenciaFacturasAsync();

                try
                {
                    await _ctx.SaveChangesAsync();
                }
                catch (DbUpdateException retryEx) when (EsViolacionPkFacturas(retryEx))
                {
                    throw new InvalidOperationException(
                        "No se pudo crear la factura porque la secuencia de IDs de facturas esta desincronizada. Intenta nuevamente.",
                        retryEx);
                }
            }
            catch (DbUpdateException ex) when (EsNumeroFacturaDuplicado(ex))
            {
                factura.NumeroFactura = await GenerarNumeroFacturaAsync();
                await _ctx.SaveChangesAsync();
            }

            foreach (var ins in inscripciones)
            {
                _ctx.DetalleFacturas.Add(new DetalleFactura
                {
                    IdFactura      = factura.IdFactura,
                    IdInscripcion  = ins.IdInscripcion,
                    PrecioUnitario = ins.IdEventoNavigation.PrecioInscripcion,
                    Cantidad       = 1,
                    SubtotalLinea  = ins.IdEventoNavigation.PrecioInscripcion
                });
            }
            await _ctx.SaveChangesAsync();

            await _ctx.Database.ExecuteSqlInterpolatedAsync($"""
                CALL public.sp_update_factura(
                    {factura.IdFactura},
                    {vm.IdEstadoPago},
                    {descuentoPct},
                    {null}
                )
                """);

            if (aplicarDescuentoAutomatico)
            {
                await ReiniciarDescuentoAutomaticoAsync(idPropietarioFactura);
            }

            await tx.CommitAsync();
        }
        catch
        {
            await tx.RollbackAsync();
            throw;
        }
    }

    private async Task<string> GenerarNumeroFacturaAsync()
    {
        var prefijo = $"FAC-{DateTime.Now:yyyy}-";

        var numeros = await _ctx.Facturas
            .AsNoTracking()
            .Where(f => f.NumeroFactura.StartsWith(prefijo))
            .Select(f => f.NumeroFactura)
            .ToListAsync();

        var maxConsecutivo = 0;
        foreach (var numero in numeros)
        {
            if (string.IsNullOrWhiteSpace(numero) || numero.Length <= prefijo.Length)
                continue;

            var sufijo = numero[prefijo.Length..];
            if (int.TryParse(sufijo, out var consecutivo) && consecutivo > maxConsecutivo)
                maxConsecutivo = consecutivo;
        }

        return $"{prefijo}{(maxConsecutivo + 1):D6}";
    }

    private async Task EjecutarEvaluacionPropietariosFrecuentesAsync()
    {
        await _ctx.Database.ExecuteSqlRawAsync("CALL public.sp_evaluar_propietarios_frecuentes()");
    }

    private async Task<bool> DebeAplicarseDescuentoAutomaticoAsync(int idPropietario)
    {
        return await _ctx.Propietarios
            .AsNoTracking()
            .Where(p => p.IdPropietario == idPropietario)
            .Select(p => p.DescuentoProximaFactura ?? false)
            .FirstOrDefaultAsync();
    }

    private async Task ReiniciarDescuentoAutomaticoAsync(int idPropietario)
    {
        var propietario = await _ctx.Propietarios.FindAsync(idPropietario);
        if (propietario is null)
        {
            return;
        }

        propietario.DescuentoProximaFactura = false;
        propietario.FechaUltimaRevisionDescuento = DateTime.Now;
        await _ctx.SaveChangesAsync();
    }

    public async Task CargarSelectsPagoAsync(RegistrarPagoViewModel vm)
    {
        vm.MetodosPago = await _ctx.TcMetodoPagos
            .Select(m => new SelectListItem(m.Descripcion, m.IdMetodoPago.ToString()))
            .ToListAsync();

        var pagado = await _ctx.HistorialTransacciones
            .Where(t => t.IdFactura == vm.IdFactura)
            .SumAsync(t => (decimal?)t.Monto) ?? 0;

        vm.SaldoPendiente = vm.TotalFactura - pagado;
    }

    public async Task RegistrarPagoAsync(RegistrarPagoViewModel vm)
    {
        _ctx.HistorialTransacciones.Add(new HistorialTransaccione
        {
            IdFactura     = vm.IdFactura,
            IdMetodoPago  = vm.IdMetodoPago,
            FechaPago     = DateTime.Now,
            Monto         = vm.Monto,
            Referencia    = vm.Referencia,
            Observaciones = vm.Observaciones
        });

        var pagado = await _ctx.HistorialTransacciones
            .Where(t => t.IdFactura == vm.IdFactura)
            .SumAsync(t => (decimal?)t.Monto) ?? 0;
        pagado += vm.Monto;

        var factura = await _ctx.Facturas.FindAsync(vm.IdFactura);
        if (factura is not null && pagado >= factura.Total)
        {
            var estadoPagado = await _ctx.TcEstadoPagos
                .Where(e => e.Descripcion.ToLower().Contains("pagad"))
                .Select(e => e.IdEstadoPago)
                .FirstOrDefaultAsync();
            if (estadoPagado != 0)
                factura.IdEstadoPago = estadoPagado;
        }

        await _ctx.SaveChangesAsync();
    }

    private async Task SincronizarSecuenciaFacturasAsync()
    {
        await _ctx.Database.ExecuteSqlRawAsync("""
            SELECT setval(
                COALESCE(pg_get_serial_sequence('public.facturas', 'id_factura'), 'public.facturas_id_factura_seq'),
                COALESCE((SELECT MAX(id_factura) FROM public.facturas), 0) + 1,
                false
            );
            """);
    }

    private static bool EsViolacionPkFacturas(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "facturas_pkey", StringComparison.OrdinalIgnoreCase);
    }

    private static bool EsNumeroFacturaDuplicado(Exception ex)
    {
        var pgEx = ex as PostgresException
            ?? ex.InnerException as PostgresException
            ?? ex.GetBaseException() as PostgresException;

        return pgEx?.SqlState == "23505"
            && string.Equals(pgEx.ConstraintName, "facturas_numero_factura_key", StringComparison.OrdinalIgnoreCase);
    }
}
