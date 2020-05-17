using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class UserSubscriptionMixCategoryIngredient
    {
        public string Id { get; set; }
        public string UserSubscriptionMixCategoryId { get; set; }
        public string IngredientId { get; set; }
        public bool Deleted { get; set; } = false;
        public int Weight { get; set; }
        public Ingredient Ingredient { get; set; }
        public UserSubscriptionMixCategory UserSubscriptionMixCategory { get; set; }
    }
}
