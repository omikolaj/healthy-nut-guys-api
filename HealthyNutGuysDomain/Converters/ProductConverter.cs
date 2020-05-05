using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class ProductConverter
    {
        public static ProductViewModel Convert(Product product)
        {
            ProductViewModel model = new ProductViewModel();
            model.Id = product.Id;
            model.CategoryId = product.CategoryId;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Subtitle = product.Subtitle;
            model.ImageSrc = product?.ImageSrc;
            model.Price = product?.Price;
            model.IsOnSale = product.IsOnSale;            
            model.ProductDetails = ProductDetailsConverter.ConvertList(product.ProductDetails);
            model.Category = CategoryConverter.Convert(product?.Category);
            model.Tags = TagConverter.ConvertList(product?.Tags);            

            return model;
        }

        public static List<ProductViewModel> ConvertList(IEnumerable<Product> products)
        {
            return products.Select(product => Convert(product)).ToList();
        }
    }
}
