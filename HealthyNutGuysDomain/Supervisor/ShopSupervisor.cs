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
            List<SpecialOffer> shopOffers = specialOffers.Where(o => o.Scope == OfferScope.Shop && o.ExpireDate < DateTime.Now).ToList();

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
                        // check if promo is valid
                        if(promoViewModel.ExpireDate > DateTime.Now)
                        {
                            shopOffer.PromoCode = promoViewModel;
                        }                        
                    }                    
                }
            }

            return shopOffer;
        }

        public async Task<List<ProductViewModel>> GetAllProductsAsync(CancellationToken ct = default)
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
                    List<SaleItem> sales = await this._saleItemRepository.GetByProductId(product.Id);
                    List<SaleItemViewModel> saleViews = new List<SaleItemViewModel>();
                    foreach (SaleItem sale in sales)
                    {
                        // if sale is valid
                        if(sale.ExpireDate > DateTime.Now)
                        {
                            SaleItemViewModel saleView = SaleItemConverter.Convert(sale);
                            saleViews.Add(saleView);
                        }
                    }
                    productView.Sales = saleViews;
                }

                productsView.Add(productView);
            }

            return productsView;
        }

        public async Task<List<CustomProductViewModel>> GetAllCustomProdctsAsync(CancellationToken ct = default)
        {
            // get all custom products here
            List<CustomProductViewModel> customProducts = new List<CustomProductViewModel>();
            customProducts.Add(await this.GetCustomSackProdctAsync(ct));

            return customProducts;
        }


        private async Task<CustomProductViewModel> GetCustomSackProdctAsync(CancellationToken ct = default)
        {
            CustomProduct customSack = await this._customProductRepository.GetCustomSackAsync(ct);
            List<MixCategory> mixCategories = await this._mixCategoryRepository.GetAllByProductIdAsync(customSack.Id);            

            foreach (MixCategory category in mixCategories)
            {
                category.Ingredients = await this._ingredientRepository.GetAllByMixCategoryIdAsync(category.Id, ct);
            }

            customSack.MixCategories = mixCategories;

            CustomProductViewModel customSackView = CustomProductConverter.Convert(customSack);

            if (customSackView.IsOnSale == true)
            {
                List<SaleItem> sales = await this._saleItemRepository.GetByCustomProductId(customSack.Id);
                List<SaleItemViewModel> saleViews = new List<SaleItemViewModel>();
                foreach (SaleItem sale in sales)
                {
                    SaleItemViewModel saleView = SaleItemConverter.Convert(sale);
                    // if sale item is a promo code
                    if (sale.Type == OfferType.PromoCode)
                    {
                        // ensure promo code id exists on 
                        if (String.IsNullOrEmpty(sale.PromoCodeId) == false)
                        {
                            PromoCodeViewModel promoViewModel = PromoCodeConverter.Convert(await this._promoCodeRepository.GetByIdAsync(sale.PromoCodeId, ct));
                            // check if promo is valid
                            if (promoViewModel.ExpireDate > DateTime.Now)
                            {
                                saleView.PromoCode = promoViewModel;
                                saleViews.Add(saleView);
                            }
                        }
                    }
                    else
                    {
                        // if sale is valid
                        if (sale.ExpireDate > DateTime.Now)
                        {                            
                            saleViews.Add(saleView);
                        }
                    }                    
                }
                customSackView.Sales = saleViews;
            }           

            return customSackView;
        }
    }
}
