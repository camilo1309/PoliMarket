using MediatR;

namespace PoliMarket.Application.Commands.LoginUser;

public class LoginCommand : IRequest<bool>
{
    public string? Username { get; set; }
    public string? Password { get; set; }
}
