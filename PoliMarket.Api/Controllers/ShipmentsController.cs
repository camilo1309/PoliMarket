using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Commands.CreateShipment;
using PoliMarket.Application.Queries.GetShipmentByInvoiceId;

namespace PoliMarket.Api.Controllers
{
    public class ShipmentsController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateShipmentCommand command)
        {
            var dto = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetByInvoice), new { invoiceId = dto.InvoiceId }, dto);
        }

        [HttpGet("{invoiceId:int}")]
        public async Task<IActionResult> GetByInvoice(int invoiceId)
        {
            var dto = await Mediator.Send(new GetShipmentByInvoiceIdQuery { InvoiceId = invoiceId });
            if (dto == null) return NotFound();
            return Ok(dto);
        }
    }
}
