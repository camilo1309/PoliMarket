using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Queries.GetShipmentByInvoiceId;

public class GetShipmentByInvoiceIdQuery : IRequest<ShipmentDto>
{
    public string? InvoiceId { get; set; }
}
