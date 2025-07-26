using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Queries.GetRoles;

namespace PoliMarket.Api.Controllers;

public class RolesController : BaseApiController
{
    [HttpGet("GetRoles")]
    public async Task<IActionResult> GetRoles()
    {
        var report = await Mediator.Send(new GetRolesQuery());
        return Ok(report);
    }
}
