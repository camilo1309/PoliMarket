using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Queries.GetCustomersReport;

namespace PoliMarket.Api.Controllers;

public class CustomersController : BaseApiController
{
    [HttpGet("GetReport")]
    public async Task<IActionResult> GetReport()
    {
        var report = await Mediator.Send(new GetCustomersReportQuery());
        return Ok(report);
    }
}
