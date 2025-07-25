using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Commands.LoginUser;

namespace PoliMarket.Api.Controllers;

public class AuthController : BaseApiController
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginCommand command)
    {
        var result = await Mediator.Send(command);

        if (!result)
            return Unauthorized(new { message = "Usuario o contraseña incorrectos." });

        return Ok(new { success = true });
    }
}
