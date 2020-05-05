using HealthyNutGuysDomain.Converters;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDomain.Supervisor
{
    public partial class HealthyNutGuysSupervisor : IHealthyNutGuysSupervisor
    {
        public async Task<SpecialOfferViewModel> GetValidShopOfferAsync(CancellationToken ct = default)
        {
            // retrieve all special offers
            List<SpecialOffer> specialOffers = await this._specialOfferRepository.GetAllAsync(ct);
            List<SpecialOffer> shopOffers = specialOffers.Where(o => o.Scope == OfferScope.Shop && o.ExpireDate > DateTime.Today).ToList();

            SpecialOfferViewModel shopOffer = null;
            // if the count is greater than 1 then we have a problem, we only ever want to display one shop offer
            if (shopOffers.Count == 1)
            {
                shopOffer = SpecialOfferConverter.Convert(shopOffers.First());

                // check if shop offer is a promo code
                if(shopOffer.Type == OfferType.PromoCode)
                {
                    if(String.IsNullOrEmpty(shopOffer.PromoCodeId) == false)
                    {
                        PromoCodeViewModel promoViewModel = PromoCodeConverter.Convert(await this._promoCodeRepository.GetByIdAsync(shopOffer.PromoCodeId, ct));
                        shopOffer.PromoCode = promoViewModel;
                    }                    
                }
            }

            return shopOffer;
        }

        public async Task<List<ProductViewModel>> GetAllProducts(CancellationToken ct = default)
        {
            // retrieve all products that are available
            List<Product> products = await this._productRepository.GetAllAsync(ct);

            List<ProductViewModel> productsView = new List<ProductViewModel>();

            // check if item has any sales
            foreach (Product product in products)
            {
                ProductViewModel productView = ProductConverter.Convert(product);

                if (product.IsOnSale == true)
                {
                    List<SaleItemViewModel> saleItemViews = SaleItemConverter.ConvertList(await this._saleItemRepository.GetByProductId(product.Id));
                    productView.Sales = saleItemViews;
                }

                productsView.Add(productView);
            }

            return productsView;
        }
    }
}
