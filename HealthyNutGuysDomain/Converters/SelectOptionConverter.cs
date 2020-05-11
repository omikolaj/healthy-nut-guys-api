using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class SelectOptionConverter
    {
        public static SelectOptionViewModel Convert(SelectOption option)
        {
            SelectOptionViewModel model = new SelectOptionViewModel();            
            model.Option = option.Option;
            model.Id = option.Id;

            return model;
        }

        public static List<SelectOptionViewModel> ConvertList(IEnumerable<SelectOption> options)
        {
            return options.Select(option => Convert(option)).ToList();
        }
    }
}
