using PoliMarket.Domain.Entities;

namespace PoliMarket.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User?> GetByUsernameAsync(string username);
}
