using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class CustomSelectOptionConverter
    {
        public static CustomSelectOptionViewModel Convert(CustomSelectOption option)
        {
            CustomSelectOptionViewModel model = new CustomSelectOptionViewModel();
            model.Option = option.Option;

            return model;
        }

        public static List<CustomSelectOptionViewModel> ConvertList(IEnumerable<CustomSelectOption> options)
        {
            return options.Select(option => Convert(option)).ToList();
        }
    }
}
