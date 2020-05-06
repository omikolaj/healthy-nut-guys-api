using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class MixCategoryConverter
    {
        public static MixCategoryViewModel Convert(MixCategory mix)
        {
            MixCategoryViewModel model = new MixCategoryViewModel();
            model.Id = mix.Id;
            model.InStock = mix.InStock;
            model.Name = mix.Name;
            model.CustomProductId = mix.CustomProductId;
            model.Type = mix.Type;
            if (mix.Ingredients != null)
                model.Ingredients = IngredientConverter.ConvertList(mix.Ingredients);            

            return model;
        } 

        public static List<MixCategoryViewModel> ConvertList(IEnumerable<MixCategory> mixes)
        {
            return mixes.Select(mix => Convert(mix)).ToList();
        }
    }
}
