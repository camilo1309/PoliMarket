using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Commands.CreateShipment;

public class CreateShipmentCommand : IRequest<ShipmentDto>
{
    public string? InvoiceId { get; set; }
    public string? ReceiverName { get; set; }
    public string? ReceiverPhone { get; set; }
    public string? ShippingAddress { get; set; }
    public DateTime ShippingDate { get; set; } = DateTime.UtcNow;
}
