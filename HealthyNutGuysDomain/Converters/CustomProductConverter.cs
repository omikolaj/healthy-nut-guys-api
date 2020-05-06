using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class CustomProductConverter
    {
        public static CustomProductViewModel Convert(CustomProduct product)
        {
            CustomProductViewModel model = new CustomProductViewModel();
            model.Id = product.Id;
            model.CategoryId = product.CategoryId;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Subtitle = product.Subtitle;
            model.ImageSrc = product.ImageSrc;
            model.Price = product?.Price;
            model.IsOnSale = product.IsOnSale;
            model.Type = product.Type;
            model.Category = CategoryConverter.Convert(product.Category);
            if(product.MixCategories != null)
                model.MixCategories = MixCategoryConverter.ConvertList(product.MixCategories);            
            model.Tags = TagConverter.ConvertList(product.Tags);
            if(product.SelectOptions != null)
                model.SelectOptions = CustomSelectOptionConverter.ConvertList(product.SelectOptions);

            return model;
        }

        public static List<CustomProductViewModel> ConvertList(IEnumerable<CustomProduct> products)
        {
            return products.Select(product => Convert(product)).ToList();
        }
    }
}
