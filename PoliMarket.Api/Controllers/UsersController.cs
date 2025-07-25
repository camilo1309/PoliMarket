using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Commands.AssignRoleToUser;

namespace PoliMarket.Api.Controllers;

public class UsersController : BaseApiController
{

    [HttpPost("AssignRole")]
    public async Task<IActionResult> AssignRole([FromBody] AssignRoleToUserCommand command)
    {
        var result = await Mediator.Send(command);

        if (!result)
            return NotFound(new { message = "Usuario o rol no encontrado." });

        return Ok(new { success = true, message = "Rol asignado correctamente." });
    }
}