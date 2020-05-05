using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class CategoryConverter
    {
        public static CategoryViewModel Convert(Category category)
        {
            CategoryViewModel model = new CategoryViewModel();
            model.Id = category.Id;
            model.Name = category.Name;

            return model;
        }

        public static List<CategoryViewModel> ConvertList(IEnumerable<Category> categories)
        {
            return categories.Select(category => Convert(category)).ToList();
        }
    }
}
