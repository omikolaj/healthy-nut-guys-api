using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Ingredient
    {
        public string Id { get; set; }
        public string MixCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool InStock { get; set; }
        public bool Deleted { get; set; } = false;
        public MixCategory MixCategory { get; set; }
    }
}
