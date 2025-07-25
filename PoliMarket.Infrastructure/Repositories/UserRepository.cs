using Microsoft.EntityFrameworkCore;
using PoliMarket.Domain.Entities;
using PoliMarket.Domain.Interfaces.Repositories;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Infrastructure.Repositories;

public class UserRepository(Context context) : IUserRepository
{
    public async Task<User?> GetByUsernameAsync(string username)
        => await context.Users.FirstOrDefaultAsync(u => u.FirstName == username);
}
