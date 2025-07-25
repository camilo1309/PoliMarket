using MediatR;
using PoliMarket.Domain.Interfaces.Repositories;

namespace PoliMarket.Application.Commands.LoginUser;

public class LoginCommandHandler(IUserRepository userRepository) : IRequestHandler<LoginCommand, bool>
{
    public async Task<bool> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
            throw new ArgumentException("El nombre de usuario es obligatorio.");

        if (string.IsNullOrWhiteSpace(request.Password))
            throw new ArgumentException("La contraseña es obligatoria.");

        var user = await userRepository.GetByUsernameAsync(request.Username);
        if (user == null) return false;

        return user.Password == request.Password;
    }
}