using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Queries.GetCustomersReport;

public class GetCustomersReportQueryHandler(Context context)
    : IRequestHandler<GetCustomersReportQuery, List<CustomerReportDto>>
{
    public async Task<List<CustomerReportDto>> Handle(
        GetCustomersReportQuery request,
        CancellationToken cancellationToken)
    {
        var report = await context.Customers
            .Include(c => c.Invoices)
            .Select(c => new CustomerReportDto
            {
                CustomerId = c.CustomerId,
                CustomerName = c.Name,
                Address = c.Address,
                TotalInvoices = c.Invoices!.Count,
                TotalQuantity = c.Invoices.Sum(i => (int?)i.QuantitySold) ?? 0,
                LastInvoiceDate = c.Invoices.OrderByDescending(i => i.InvoiceDate)
                                            .Select(i => (DateTime?)i.InvoiceDate)
                                            .FirstOrDefault()
            })
            .ToListAsync(cancellationToken);

        return report;
    }
}
