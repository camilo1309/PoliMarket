namespace PoliMarket.Domain.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public int StockQuantity { get; set; }

    public virtual ICollection<Invoice>? Invoices { get; set; }
    public virtual ICollection<ProviderProduct>? ProviderProducts { get; set; }
}
