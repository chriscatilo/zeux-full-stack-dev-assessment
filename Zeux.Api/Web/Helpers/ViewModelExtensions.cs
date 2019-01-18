using System.Collections.Generic;
using Zeux.Api.Domain;
using Zeux.Api.Web.ViewModels;

namespace Zeux.Api.Web
{
    public static class ViewModelExtensions
    {
        public static IEnumerable<AssetListItem> ToAssetListItems(this IEnumerable<PortfolioAsset> source)
        {
            foreach (var asset in source)
            {
                var product = asset.Product;

                yield return new AssetListItem
                {
                    ProductName = product.Name,
                    ProductType = product.Type.Name,
                    Currency = product.CurrencyCode,
                    Returns = product.Returns,
                    ReturnsBasis = product.ReturnsBasis.Name,
                    Valuation = asset.Valuation
                };
            }
        } 
    }
}
