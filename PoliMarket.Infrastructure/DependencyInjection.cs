using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PoliMarket.Domain.Interfaces.Repositories;
using PoliMarket.Infrastructure.Data;
using PoliMarket.Infrastructure.Repositories;

namespace PoliMarket.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
