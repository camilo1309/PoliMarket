using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Application.Models;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Queries.GetRoles;

public class GetRolesQueryHandler(Context context) : IRequestHandler<GetRolesQuery, List<GetRolesDto>>
{
    public async Task<List<GetRolesDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        return await context.Roles.Select(r => new GetRolesDto()
        {
            RoleId = r.RoleId,
            RoleName = r.RoleName,
        }).ToListAsync();
    }
}
