using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class ProductDetailsConverter
    {
        public static ProductDetailsViewModel Convert(ProductDetails productDetails)
        {
            ProductDetailsViewModel model = new ProductDetailsViewModel();
            model.Id = productDetails.Id;
            model.ProductId = productDetails.ProductId;
            model.LabelSrc = productDetails.LabelSrc;
            model.Price = productDetails.Price;
            model.SelectOption = SelectOptionConverter.Convert(productDetails.SelectOption);

            return model;
        }

        public static List<ProductDetailsViewModel> ConvertList(IEnumerable<ProductDetails> productDetailsList)
        {
            return productDetailsList.Select(productDetails => Convert(productDetails)).ToList();
        }
    }
}
