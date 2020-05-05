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
            model.ExpireDate = saleItem.ExpireDate;
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
