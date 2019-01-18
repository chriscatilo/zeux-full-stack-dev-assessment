using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Zeux.Api.Domain;
using Zeux.Api.Web.ViewModels;

namespace Zeux.Api.Web
{
    public static class QueryStringHelpers
    {
        public static ProductType ToProductType(this ProductTypeFilter filter)
        {
            switch (filter)
            {
                case ProductTypeFilter.Fund:
                    return ProductType.Funds;

                case ProductTypeFilter.P2P:
                    return ProductType.PeerToPeer;

                case ProductTypeFilter.Save:
                    return ProductType.Savings;
                    
                case ProductTypeFilter.All:
                default:
                    return null;
            }
        }
    }
}
