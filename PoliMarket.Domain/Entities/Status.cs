namespace PoliMarket.Domain.Entities;

public class Status
{
    public int StatusId { get; set; }
    public string? StatusName { get; set; }

    public virtual ICollection<Customer>? Customers { get; set; }
    public virtual ICollection<User>? Users { get; set; }
    public virtual ICollection<Provider>? Providers { get; set; }
}
