using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hipodromo_Nacional.ViewModels;

public class FacturaListViewModel
{
    public int IdFactura { get; set; }
    public string NumeroFactura { get; set; } = string.Empty;
    public DateTime? FechaFactura { get; set; }
    public string Propietario { get; set; } = string.Empty;
    public decimal Subtotal { get; set; }
    public decimal DescuentoPct { get; set; }
    public decimal MontoDescuento { get; set; }
    public decimal ImpuestoIva { get; set; }
    public decimal ComisionAdmin { get; set; }
    public decimal Total { get; set; }
    public string EstadoPago { get; set; } = string.Empty;
    public int IdEstadoPago { get; set; }
}

public class FacturaDetalleViewModel
{
    public int IdFactura { get; set; }
    public string NumeroFactura { get; set; } = string.Empty;
    public DateTime? FechaFactura { get; set; }
    public string Propietario { get; set; } = string.Empty;
    public decimal Subtotal { get; set; }
    public decimal DescuentoPct { get; set; }
    public decimal MontoDescuento { get; set; }
    public decimal BaseImponible { get; set; }
    public decimal ImpuestoIva { get; set; }
    public decimal ComisionAdmin { get; set; }
    public decimal Total { get; set; }
    public string EstadoPago { get; set; } = string.Empty;
    public int IdEstadoPago { get; set; }

    public List<DetalleFacturaViewModel> Detalles { get; set; } = [];
    public List<TransaccionViewModel> Transacciones { get; set; } = [];
}

public class DetalleFacturaViewModel
{
    public int IdDetalle { get; set; }
    public string Evento { get; set; } = string.Empty;
    public string Caballo { get; set; } = string.Empty;
    public DateTime? FechaInscripcion { get; set; }
    public decimal PrecioUnitario { get; set; }
    public int Cantidad { get; set; }
    public decimal SubtotalLinea { get; set; }
}

public class TransaccionViewModel
{
    public int IdTransaccion { get; set; }
    public int IdFactura { get; set; }
    public DateTime? FechaPago { get; set; }
    public decimal Monto { get; set; }
    public string MetodoPago { get; set; } = string.Empty;
    public string? Referencia { get; set; }
    public string? Observaciones { get; set; }
}

public class RegistrarPagoViewModel
{
    public int IdFactura { get; set; }
    public string NumeroFactura { get; set; } = string.Empty;
    public decimal TotalFactura { get; set; }
    public decimal SaldoPendiente { get; set; }

    [Required]
    [Display(Name = "Método de Pago")]
    public int IdMetodoPago { get; set; }

    [Required]
    [Display(Name = "Monto")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a 0")]
    public decimal Monto { get; set; }

    [Display(Name = "Referencia")]
    public string? Referencia { get; set; }

    [Display(Name = "Observaciones")]
    public string? Observaciones { get; set; }

    public IEnumerable<SelectListItem> MetodosPago { get; set; } = [];
}

public class CrearFacturaViewModel
{
    [Required]
    [Display(Name = "Propietario")]
    public int IdPropietario { get; set; }

    [Required]
    [Display(Name = "N° Factura")]
    public string NumeroFactura { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Fecha")]
    public DateTime FechaFactura { get; set; } = DateTime.Today;

    [Display(Name = "Descuento (%)")]
    [Range(0, 100)]
    public decimal DescuentoPct { get; set; } = 0;

    [Required]
    [Display(Name = "Estado de Pago")]
    public int IdEstadoPago { get; set; }

    public List<int> InscripcionesSeleccionadas { get; set; } = [];

    public IEnumerable<SelectListItem> Propietarios { get; set; } = [];
    public IEnumerable<SelectListItem> EstadosPago { get; set; } = [];
    public List<InscripcionSelectViewModel> InscripcionesDisponibles { get; set; } = [];
}

public class InscripcionSelectViewModel
{
    public int IdInscripcion { get; set; }
    public int IdPropietario { get; set; }
    public string Propietario { get; set; } = string.Empty;
    public string Evento { get; set; } = string.Empty;
    public string Caballo { get; set; } = string.Empty;
    public DateTime? FechaInscripcion { get; set; }
    public decimal PrecioUnitario { get; set; }
}
