using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Commands.CreateOrder;
using PoliMarket.Application.Queries.GetOrdersReport;

namespace PoliMarket.Api.Controllers
{
    public class OrdersController : BaseApiController
    {
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        {
            var invoiceId = await Mediator.Send(command);
            return Ok(new { InvoiceId = invoiceId, Message = "Orden creada exitosamente." });
        }

        [HttpGet("GetOrderReport")]
        public async Task<IActionResult> GetOrderReport()
        {
            var report = await Mediator.Send(new GetOrdersReportQuery());
            return Ok(report);
        }
    }
}
