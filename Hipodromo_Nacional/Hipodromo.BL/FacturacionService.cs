using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.ViewModels;

namespace Hipodromo_Nacional.Hipodromo.BL;

public class FacturacionService
{
    private readonly PostgresContext _ctx;

    public FacturacionService(PostgresContext ctx) => _ctx = ctx;

    public async Task<List<FacturaListViewModel>> ObtenerListaAsync()
    {
        return await _ctx.Facturas
            .Include(f => f.IdPropietarioNavigation).ThenInclude(p => p.IdUsuarioNavigation)
            .Include(f => f.IdEstadoPagoNavigation)
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

    public async Task<FacturaDetalleViewModel?> ObtenerDetalleAsync(int id)
    {
        var f = await _ctx.Facturas
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
            .FirstOrDefaultAsync(f => f.IdFactura == id);

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
        vm.Propietarios = await _ctx.Propietarios
            .Include(p => p.IdUsuarioNavigation)
            .Select(p => new SelectListItem(
                p.IdUsuarioNavigation.Nombre + " " + p.IdUsuarioNavigation.Apellido1,
                p.IdPropietario.ToString()))
            .ToListAsync();

        vm.EstadosPago = await _ctx.TcEstadoPagos
            .Select(e => new SelectListItem(e.Descripcion, e.IdEstadoPago.ToString()))
            .ToListAsync();

        vm.InscripcionesDisponibles = await _ctx.Inscripciones
            .Include(i => i.IdEventoNavigation)
            .Include(i => i.IdCaballoNavigation)
            .Where(i => !_ctx.DetalleFacturas.Any(d => d.IdInscripcion == i.IdInscripcion))
            .Select(i => new InscripcionSelectViewModel
            {
                IdInscripcion    = i.IdInscripcion,
                Evento           = i.IdEventoNavigation.Nombre,
                Caballo          = i.IdCaballoNavigation.Nombre,
                FechaInscripcion = i.FechaInscripcion,
                PrecioUnitario   = i.IdEventoNavigation.PrecioInscripcion
            })
            .ToListAsync();
    }

    public async Task CrearAsync(CrearFacturaViewModel vm)
    {
        var inscripciones = await _ctx.Inscripciones
            .Include(i => i.IdEventoNavigation)
            .Where(i => vm.InscripcionesSeleccionadas.Contains(i.IdInscripcion))
            .ToListAsync();

        var subtotal = inscripciones.Sum(i => i.IdEventoNavigation.PrecioInscripcion);
        var montoDescuento = Math.Round(subtotal * vm.DescuentoPct / 100, 2);
        var baseImponible = subtotal - montoDescuento;
        var iva = Math.Round(baseImponible * 0.13m, 2);
        var comision = inscripciones.Sum(i => i.IdEventoNavigation.ComisionAdmin);
        var total = baseImponible + iva + comision;

        var factura = new Factura
        {
            IdPropietario  = vm.IdPropietario,
            NumeroFactura  = vm.NumeroFactura,
            FechaFactura   = vm.FechaFactura,
            Subtotal       = subtotal,
            DescuentoPct   = vm.DescuentoPct,
            MontoDescuento = montoDescuento,
            BaseImponible  = baseImponible,
            ImpuestoIva    = iva,
            ComisionAdmin  = comision,
            Total          = total,
            IdEstadoPago   = vm.IdEstadoPago
        };

        _ctx.Facturas.Add(factura);
        await _ctx.SaveChangesAsync();

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
}
