using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class MixCategory
    {
        public string Id { get; set; }        
        public bool InStock { get; set; }
        public string Name { get; set; }
        public bool? Deleted { get; set; } = false;
        public int Type { get; set; }        
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
