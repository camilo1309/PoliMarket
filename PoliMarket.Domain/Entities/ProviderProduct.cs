namespace PoliMarket.Domain.Entities;

public class ProviderProduct
{
    public int ProviderId { get; set; }
    public int ProductId { get; set; }
    public string? Quality { get; set; }

    public virtual Provider? Provider { get; set; }
    public virtual Product? Product { get; set; }
}
