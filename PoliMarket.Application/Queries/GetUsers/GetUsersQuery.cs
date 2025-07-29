using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Queries.GetUsers;

public class GetUsersQuery : IRequest<List<UserDto>>
{
}
