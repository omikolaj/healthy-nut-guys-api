using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class UserSubscriptionMixCategory
    {
        public string Id { get; set; }
        public string UserSubscriptionProductId { get; set; }
        public string MixCategoryId { get; set; }
        public bool Deleted { get; set; } = false;
        public MixCategory MixCategory { get; set; }
        public UserSubscriptionProduct UserSubscriptionProduct { get; set; }
        public ICollection<UserSubscriptionMixCategoryIngredient> Ingredients { get; set; }
    }
}
