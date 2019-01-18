using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace Zeux.Api.Domain
{
    public class ProductType
    {
        public static ProductType Savings = new ProductType { Code = "Save", Name = "Savings" };

        public static ProductType PeerToPeer = new ProductType { Code = "P2P", Name = "P2P" };

        public static ProductType Funds = new ProductType { Code = "Funds", Name = "Funds" };

        public string Code { get; private set; }

        public string Name { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is ProductType other && this.Equals(other);
        }

        protected bool Equals(ProductType other)
        {
            return string.Equals(Code, other.Code) && string.Equals(Name, other.Name);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Code != null ? Code.GetHashCode() : 0) * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }
    }
}
