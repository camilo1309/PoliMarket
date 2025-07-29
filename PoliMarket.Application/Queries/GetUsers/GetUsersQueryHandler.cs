using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Queries.GetUsers;

public class GetUsersQueryHandler(Context context) : IRequestHandler<GetUsersQuery, List<UserDto>>
{
    public async Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return await context.Users
            .AsNoTracking()
            .Select(u => new UserDto
            {
                UserId = u.UserId,
                Name = u.FirstName,
                Status = u.Status!.StatusName,
                Role = u.UserRoles!.FirstOrDefault()!.Role!.RoleName
            })
            .ToListAsync(cancellationToken);
    }
}
