using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class MixCategory
    {
        public string Id { get; set; }
        public string IngredientId { get; set; }
        public bool InStock { get; set; }
        public int Type { get; set; }        
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
