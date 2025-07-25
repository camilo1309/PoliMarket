namespace PoliMarket.Domain.Entities;

public class Shipment
{
    public int InvoiceId { get; set; }
    public string? ReceiverName { get; set; }
    public string? ReceiverPhone { get; set; }
    public string? ShippingAddress { get; set; }
    public DateTime ShippingDate { get; set; }
    public string? ShippingStatus { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
