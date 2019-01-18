using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Zeux.Api.Domain
{
    public class PortfolioAsset
    {
        public Product Product { get; set; }

        public long Valuation { get; set; }
    }
}
