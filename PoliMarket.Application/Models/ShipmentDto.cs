namespace PoliMarket.Application.Models;

public class ShipmentDto
{
    public string? InvoiceId { get; set; }
    public string? ReceiverName { get; set; }
    public string? ReceiverPhone { get; set; }
    public string? ShippingAddress { get; set; }
    public DateTime ShippingDate { get; set; }
    public string? ShippingStatus { get; set; }
}
