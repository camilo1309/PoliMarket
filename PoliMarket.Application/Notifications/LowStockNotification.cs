using MediatR;

namespace PoliMarket.Application.Notifications;

public class LowStockNotification : INotification
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public int CurrentStock { get; set; }
}
