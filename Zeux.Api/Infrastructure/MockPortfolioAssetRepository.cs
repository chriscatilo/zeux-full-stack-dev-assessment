using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeux.Api.App;
using Zeux.Api.Domain;

namespace Zeux.Api.Infrastructure
{
    public class MockPortfolioAssetRepository: IPortfolioAssetRepository
    {
        public async Task<IEnumerable<PortfolioAsset>> Get(string accountNumber, ProductType productType = null)
        {
            if (!accountNumber.Equals("1234567890"))
            {
                return new PortfolioAsset[0];
            }

            var assets = new[]
            {
                new PortfolioAsset()
                {
                   Product = new Product()
                   {
                       Code = "SAVE_A",
                       CurrencyCode = "GBP",
                       Name = "Saving A",
                       Type = ProductType.Savings,
                       Returns = 1.20,
                       ReturnsBasis = Basis.Yearly
                   },
                   Valuation = 1000,
                },
                new PortfolioAsset()
                {
                   Product = new Product()
                   {
                       Code = "SAVE_B",
                       CurrencyCode = "GBP",
                       Name = "Saving B",
                       Type = ProductType.Savings,
                       Returns = 1.80,
                       ReturnsBasis = Basis.Yearly
                   },
                   Valuation = 1500
                },
                new PortfolioAsset()
                {
                   Product = new Product()
                   {
                       Code = "P2P_A",
                       CurrencyCode = "GBP",
                       Name = "Peer to Peer A",
                       Type = ProductType.PeerToPeer,
                       Returns = 2.20,
                       ReturnsBasis = Basis.Yearly
                   },
                   Valuation = 3000
                },
                new PortfolioAsset()
                {
                   Product = new Product()
                   {
                       Code = "P2P_B",
                       CurrencyCode = "GBP",
                       Name = "Peer to Peer B",
                       Type = ProductType.PeerToPeer,
                       Returns = 3.20,
                       ReturnsBasis = Basis.Yearly
                   },
                   Valuation = 2500
                },
                new PortfolioAsset()
                {
                   Product = new Product()
                   {
                       Code = "FUND_A",
                       CurrencyCode = "GBP",
                       Name = "Funds A",
                       Type = ProductType.Funds,
                       Returns = 5.20,
                       ReturnsBasis = Basis.Yearly
                   },
                   Valuation = 10300
                },
                new PortfolioAsset()
                {
                   Product = new Product()
                   {
                       Code = "FUND_B",
                       CurrencyCode = "GBP",
                       Name = "Funds B",
                       Type = ProductType.Funds,
                       Returns = 7.20,
                       ReturnsBasis = Basis.Yearly
                   },
                   Valuation = 23000
                }
            };

            return await Task.Run(() => productType == null ? assets : assets.Where(_ => _.Product.Type.Equals(productType)).ToArray());
        }
    }
}
