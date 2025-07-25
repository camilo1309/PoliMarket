using MediatR;
using Microsoft.EntityFrameworkCore;
using PoliMarket.Domain.Entities;
using PoliMarket.Infrastructure.Data;

namespace PoliMarket.Application.Commands.AssignRoleToUser
{
    public class AssignRoleToUserCommandHandler(Context context) : IRequestHandler<AssignRoleToUserCommand, bool>
    {
        public async Task<bool> Handle(AssignRoleToUserCommand request, CancellationToken cancellationToken)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.UserId == request.UserId, cancellationToken);
            var role = await context.Roles.FirstOrDefaultAsync(r => r.RoleId == request.RoleId, cancellationToken);

            if (user == null || role == null)
                return false;

            var exists = await context.UserRoles
                .AnyAsync(ur => ur.UserId == request.UserId && ur.RoleId == request.RoleId, cancellationToken);

            if (exists)
                return true;

            context.UserRoles.Add(new UserRole
            {
                UserId = request.UserId,
                RoleId = request.RoleId
            });

            await context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}