using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class UserSubscriptionMixCategoryIngredientConverter
    {
        public static UserSubscriptionMixCategoryIngredientViewModel Convert(UserSubscriptionMixCategoryIngredient ingredient)
        {
            UserSubscriptionMixCategoryIngredientViewModel model = new UserSubscriptionMixCategoryIngredientViewModel();
            model.Id = ingredient.Id;
            model.Weight = ingredient.Weight;
            if (model.Ingredient != null)
                model.Ingredient = IngredientConverter.Convert(ingredient.Ingredient);
            
            return model;
        }

        public static List<UserSubscriptionMixCategoryIngredientViewModel> ConvertList(IEnumerable<UserSubscriptionMixCategoryIngredient> ingredients)
        {
            return ingredients.Select(ing => Convert(ing)).ToList();
        }
    }
}
