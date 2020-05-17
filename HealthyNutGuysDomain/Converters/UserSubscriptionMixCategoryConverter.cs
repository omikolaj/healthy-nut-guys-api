using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class UserSubscriptionMixCategoryConverter
    {
        public static UserSubscriptionMixCategoryViewModel Convert(UserSubscriptionMixCategory mixCategory)
        {
            UserSubscriptionMixCategoryViewModel model = new UserSubscriptionMixCategoryViewModel();
            model.Id = mixCategory.Id;
            if (mixCategory.MixCategory != null)
                model.MixCategory = MixCategoryConverter.Convert(mixCategory.MixCategory);
            if (mixCategory.Ingredients != null)
                model.Ingredients = UserSubscriptionMixCategoryIngredientConverter.ConvertList(mixCategory.Ingredients);


            return model;
        }

        public static List<UserSubscriptionMixCategoryViewModel> ConvertList(IEnumerable<UserSubscriptionMixCategory> mixCategories)
        {
            return mixCategories.Select(category => Convert(category)).ToList();
        }
    }
}
