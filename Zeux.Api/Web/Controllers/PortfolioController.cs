using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zeux.Api.App;
using Zeux.Api.Web.ViewModels;

namespace Zeux.Api.Web.Controllers
{
    [ApiController, Route("[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioAssetRepository _portfolioAssetRepository;

        public PortfolioController(IPortfolioAssetRepository portfolioAssetRepository)
        {
            _portfolioAssetRepository = portfolioAssetRepository;
        }

        [HttpGet, Route("{type?}"), Authorize]
        public async Task<IActionResult> Get(ProductTypeFilter type = ProductTypeFilter.All)
        {
            var accountNumber = User.Claims.FirstOrDefault(_ => _.Type.Equals("AccountNumber"))?.Value;

            if (string.IsNullOrEmpty(accountNumber))
            {
                return BadRequest("Account number not in claims");
            }

            var productType = type.ToProductType();

            var assets = await _portfolioAssetRepository.Get(accountNumber, productType);

            var list = assets.ToAssetListItems();

            return Ok(list);
        }
    }
}
