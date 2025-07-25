using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Queries.GetCustomersReport;

public class GetCustomersReportQuery : IRequest<List<CustomerReportDto>>
{
}
