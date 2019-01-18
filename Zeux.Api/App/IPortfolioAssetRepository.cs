using System.Collections.Generic;
using System.Threading.Tasks;
using Zeux.Api.Domain;

namespace Zeux.Api.App
{
    public interface IPortfolioAssetRepository
    {
        Task<IEnumerable<PortfolioAsset>> Get(string accountNumber, ProductType productType = null);
    }
}