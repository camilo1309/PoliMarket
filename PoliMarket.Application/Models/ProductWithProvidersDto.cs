namespace PoliMarket.Application.Models;

public class ProductWithProvidersDto
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public int StockQuantity { get; set; }
    public List<ProviderInfoDto>? Providers { get; set; }
}

public class ProviderInfoDto
{
    public string? Name { get; set; }
    public string? Quality { get; set; }
}
