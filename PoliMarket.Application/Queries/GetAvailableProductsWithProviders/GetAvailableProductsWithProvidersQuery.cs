using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Queries.GetAvailableProductsWithSuppliers;

public class GetAvailableProductsWithProvidersQuery : IRequest<List<ProductWithProvidersDto>>
{
}
