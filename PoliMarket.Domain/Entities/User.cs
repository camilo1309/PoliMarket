namespace PoliMarket.Domain.Entities;

public class User
{
    public int UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public int StatusId { get; set; }
    public DateTime StartDate { get; set; }

    public virtual Status? Status { get; set; }
    public virtual ICollection<UserRole>? UserRoles { get; set; }
}
