using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zeux.Api.Domain
{
    public class Product
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public ProductType Type { get; set; }

        public string CurrencyCode { get; set; }

        public double Returns { get; set; }

        public Basis ReturnsBasis { get; set; }
    }
}
