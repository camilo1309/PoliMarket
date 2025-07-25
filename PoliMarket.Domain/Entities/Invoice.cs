namespace PoliMarket.Domain.Entities;

public class Invoice
{
    public int InvoiceId { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int QuantitySold { get; set; }
    public DateTime InvoiceDate { get; set; }

    public virtual Customer? Customer { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Shipment? Shipment { get; set; }
}
