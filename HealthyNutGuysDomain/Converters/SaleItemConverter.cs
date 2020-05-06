using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class SaleItemConverter
    {
        public static SaleItemViewModel Convert(SaleItem saleItem)
        {
            SaleItemViewModel model = new SaleItemViewModel();
            model.Id = saleItem.Id;
            model.ProductId = saleItem.ProductId;
            model.CustomProductId = saleItem.CustomProductId;
            model.ExpireDate = saleItem.ExpireDate;
            model.PromoCodeId = saleItem?.PromoCodeId;
            if (saleItem.PromoCodeId != null)
                model.PromoCode = PromoCodeConverter.Convert(saleItem.PromoCode);
            model.SpecialOfferId = saleItem?.SpecialOfferId;
            if (saleItem.SpecialOfferId != null)
                model.SpecialOffer = SpecialOfferConverter.Convert(saleItem.SpecialOffer);
            model.Type = saleItem.Type;
            model.DiscountValue = saleItem.DiscountValue;

            return model;
        }

        public static List<SaleItemViewModel> ConvertList(IEnumerable<SaleItem> saleItems)
        {
            return saleItems.Select(saleItem => Convert(saleItem)).ToList();
        }
    }
}
