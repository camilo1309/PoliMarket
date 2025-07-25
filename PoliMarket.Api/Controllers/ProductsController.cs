using Microsoft.AspNetCore.Mvc;
using PoliMarket.Api.Controllers.Base;
using PoliMarket.Application.Queries.GetAvailableProductsWithSuppliers;

namespace PoliMarket.Api.Controllers
{
    public class ProductsController : BaseApiController
    {
        [HttpGet("GetAvailableWithSuppliers")]
        public async Task<IActionResult> GetAvailableWithSuppliers()
        {
            var result = await Mediator.Send(new GetAvailableProductsWithProvidersQuery());
            return Ok(result);
        }
    }
}
