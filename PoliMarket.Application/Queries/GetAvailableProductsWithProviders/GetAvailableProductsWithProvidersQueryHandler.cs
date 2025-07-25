using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Queries.GetAvailableProductsWithSuppliers;

public class GetAvailableProductsWithProvidersQueryHandler(Context context)
    : IRequestHandler<GetAvailableProductsWithProvidersQuery, List<ProductWithProvidersDto>>
{
    public async Task<List<ProductWithProvidersDto>> Handle(
        GetAvailableProductsWithProvidersQuery request,
        CancellationToken cancellationToken)
    {
        var result = await context.Products
            .AsNoTracking()
            .Where(p => p.StockQuantity > 0)
            .Select(p => new ProductWithProvidersDto
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                StockQuantity = p.StockQuantity,
                Providers = p.ProviderProducts!.Select(sp => new ProviderInfoDto()
                {
                    Name = sp.Provider!.Name,
                    Quality = sp.Quality
                }).ToList()
            })
            .ToListAsync(cancellationToken);

        return result;
    }
}
