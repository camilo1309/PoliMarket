using MediatR;

namespace PoliMarket.Application.Commands.AssignRoleToUser;

public class AssignRoleToUserCommand : IRequest<bool>
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
}
