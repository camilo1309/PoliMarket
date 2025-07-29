using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Notifications;
using PoliMarket.Domain.Entities;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Commands.CreateOrder;

public class CreateOrderCommandHandler(Context context, IMediator mediator) : IRequestHandler<CreateOrderCommand, string>
{
    public async Task<string> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var customer = await context.Customers
            .FirstOrDefaultAsync(c => c.CustomerId == request.CustomerId, cancellationToken);
        if (customer == null)
            throw new InvalidOperationException("Cliente no encontrado.");

        var product = await context.Products
            .FirstOrDefaultAsync(p => p.ProductId == request.ProductId, cancellationToken);
        if (product == null)
            throw new InvalidOperationException("Producto no encontrado.");

        if (product.StockQuantity < request.Quantity)
            throw new InvalidOperationException("Stock insuficiente para el producto seleccionado.");

        product.StockQuantity -= request.Quantity;

        var invoice = new Invoice
        {
            CustomerId = request.CustomerId,
            ProductId = request.ProductId,
            QuantitySold = request.Quantity,
            InvoiceDate = DateTime.UtcNow
        };

        context.Invoices.Add(invoice);
        await context.SaveChangesAsync(cancellationToken);

        if (product.StockQuantity <= 5)
        {
            await mediator.Publish(new LowStockNotification
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CurrentStock = product.StockQuantity
            }, cancellationToken);
        }

        return invoice.InvoiceId;
    }
}