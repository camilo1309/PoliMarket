﻿namespace PoliMarket.Application.Models;

public class OrderReportDto
{
    public string? InvoiceId { get; set; }
    public string? CustomerName { get; set; }
    public string? ProductName { get; set; }
    public int QuantitySold { get; set; }
    public DateTime InvoiceDate { get; set; }
}
