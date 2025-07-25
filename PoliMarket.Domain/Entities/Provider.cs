namespace PoliMarket.Domain.Entities;

public class Provider
{
    public int ProviderId { get; set; }
    public string? IdType { get; set; }
    public string? Identification { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int StatusId { get; set; }

    public virtual Status? Status { get; set; }
    public virtual ICollection<ProviderProduct>? ProviderProducts { get; set; }
}
