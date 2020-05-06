using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class MixCategory
    {
        public string Id { get; set; }
        [Required]
        public bool InStock { get; set; }
        [Required]
        public string CustomProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Deleted { get; set; } = false;
        [Required]
        public MixCategoryType Type { get; set; }        
        public ICollection<Ingredient> Ingredients { get; set; }
        public CustomProduct Product { get; set; }
    }
}
