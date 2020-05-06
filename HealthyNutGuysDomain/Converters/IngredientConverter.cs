using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class IngredientConverter
    {
        public static IngredientViewModel Convert(Ingredient ingredient)
        {
            IngredientViewModel model = new IngredientViewModel();
            model.Id = ingredient.Id;
            model.MixCategoryId = ingredient.MixCategoryId;
            model.Name = ingredient.Name;
            model.InStock = ingredient.InStock;

            return model;
        }

        public static List<IngredientViewModel> ConvertList(IEnumerable<Ingredient> ingredients)
        {
            return ingredients.Select(ingredient => Convert(ingredient)).ToList();
        }
    }
}
