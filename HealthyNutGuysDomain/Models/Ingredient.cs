using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Ingredient
    {
        public string Id { get; set; }
        public string MixCategoryId { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }
        public MixCategory MixCategory { get; set; }
    }
}
