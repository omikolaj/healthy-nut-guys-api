using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class TagConverter
    {
        public static TagViewModel Convert(Tag tag)
        {
            TagViewModel model = new TagViewModel();
            model.Id = tag.Id;
            model.Name = tag.Name;

            return model;
        }

        public static List<TagViewModel> ConvertList(IEnumerable<Tag> tags)
        {
            return tags.Select(tag => Convert(tag)).ToList();
        }
    }
}
