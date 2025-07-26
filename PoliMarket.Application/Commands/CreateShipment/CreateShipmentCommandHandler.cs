using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Domain.Entities;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Commands.CreateShipment;

public class CreateShipmentCommandHandler(Context context) : IRequestHandler<CreateShipmentCommand, ShipmentDto>
{
    public async Task<ShipmentDto> Handle(CreateShipmentCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.ReceiverName))
            throw new ArgumentException("El nombre del receptor es requerido.");
        if (string.IsNullOrWhiteSpace(request.ShippingAddress))
            throw new ArgumentException("La dirección de envío es requerida.");

        var invoice = await context.Invoices
            .AsNoTracking()
            .FirstOrDefaultAsync(i => i.InvoiceId == request.InvoiceId, cancellationToken)
            ?? throw new InvalidOperationException("La factura no existe.");


        var exists = await context.Shipments
            .AnyAsync(s => s.InvoiceId == request.InvoiceId, cancellationToken);

        if (exists)
            throw new InvalidOperationException("Ya existe un envío registrado para esta factura.");

        var shipment = new Shipment
        {
            InvoiceId = request.InvoiceId,
            ReceiverName = request.ReceiverName,
            ReceiverPhone = request.ReceiverPhone,
            ShippingAddress = request.ShippingAddress,
            ShippingDate = request.ShippingDate,
            ShippingStatus = "Created"
        };

        context.Shipments.Add(shipment);
        await context.SaveChangesAsync(cancellationToken);

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
