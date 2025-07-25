namespace PoliMarket.Application.Models;

public class CustomerReportDto
{
    public int CustomerId { get; set; }
    public string? CustomerName { get; set; }
    public string? Address { get; set; }
    public int TotalInvoices { get; set; }
    public int TotalQuantity { get; set; }
    public DateTime? LastInvoiceDate { get; set; }
}
