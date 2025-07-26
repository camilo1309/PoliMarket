using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Queries.GetShipmentByInvoiceId;

public class GetShipmentByInvoiceIdQueryHandler(Context context)
        : IRequestHandler<GetShipmentByInvoiceIdQuery, ShipmentDto>
{
    public async Task<ShipmentDto> Handle(GetShipmentByInvoiceIdQuery request, CancellationToken cancellationToken)
    {
        var shipment = await context.Shipments
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.InvoiceId == request.InvoiceId, cancellationToken);

        if (shipment == null) return new();

        return new ShipmentDto
        {
            InvoiceId = shipment.InvoiceId,
            ReceiverName = shipment.ReceiverName,
            ReceiverPhone = shipment.ReceiverPhone,
            ShippingAddress = shipment.ShippingAddress,
            ShippingDate = shipment.ShippingDate,
            ShippingStatus = shipment.ShippingStatus
        };
    }
}
