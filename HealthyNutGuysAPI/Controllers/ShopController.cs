using HealthyNutGuysAPI.Filters;
using HealthyNutGuysDomain;
using HealthyNutGuysDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ServiceFilter(typeof(ValidateModelStateAttribute))]
    public class ShopController : HealthyNutGuysBaseController
    {
        public ShopController(IHealthyNutGuysSupervisor supervisor)
        {
            this._supervisor = supervisor;
        }

        private readonly IHealthyNutGuysSupervisor _supervisor;

        [HttpGet("products")]
        public async Task<ActionResult<List<ProductViewModel>>> GetProducts(CancellationToken ct = default)
        {
            return await this._supervisor.GetAllProductsAsync(ct);
        }

        [HttpGet("custom-products")]
        public async Task<ActionResult<List<CustomProductViewModel>>> GetCustomProducts(CancellationToken ct = default)
        {
            return await this._supervisor.GetAllCustomProdctsAsync(ct);
        }

        [HttpGet("offer")]
        public async Task<ActionResult<SpecialOfferViewModel>> GetShopOffer(CancellationToken ct = default)
        {
            return await this._supervisor.GetValidShopOfferAsync(ct);
        }
    }
}
