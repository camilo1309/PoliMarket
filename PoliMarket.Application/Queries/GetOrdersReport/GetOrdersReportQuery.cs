using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Queries.GetOrdersReport;

public class GetOrdersReportQuery : IRequest<IReadOnlyCollection<OrderReportDto>>
{
}
