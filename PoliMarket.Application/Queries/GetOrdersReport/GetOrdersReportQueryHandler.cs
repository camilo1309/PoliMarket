using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Queries.GetOrdersReport;

public class GetOrdersReportQueryHandler(Context context) : IRequestHandler<GetOrdersReportQuery, IReadOnlyCollection<OrderReportDto>>
{
    public async Task<IReadOnlyCollection<OrderReportDto>> Handle(GetOrdersReportQuery request, CancellationToken cancellationToken)
    {
        var report = await context.Invoices
            .Include(f => f.Customer)
            .Include(f => f.Product)
            .AsNoTracking()
            .OrderByDescending(f => f.InvoiceDate)
            .Select(f => new OrderReportDto
            {
                InvoiceId = f.InvoiceId,
                CustomerName = f.Customer!.Name,
                ProductName = f.Product!.ProductName,
                QuantitySold = f.QuantitySold,
                InvoiceDate = f.InvoiceDate
            })
            .ToListAsync(cancellationToken);

        return report;
    }
}
