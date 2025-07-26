using MediatR;

namespace PoliMarket.Application.Commands.CreateOrder;

public class CreateOrderCommand : IRequest<int>
{
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
