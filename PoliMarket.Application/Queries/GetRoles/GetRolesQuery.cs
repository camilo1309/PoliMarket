using MediatR;
using PoliMarket.Application.Models;

namespace PoliMarket.Application.Queries.GetRoles;

public class GetRolesQuery : IRequest<List<GetRolesDto>>
{

}
