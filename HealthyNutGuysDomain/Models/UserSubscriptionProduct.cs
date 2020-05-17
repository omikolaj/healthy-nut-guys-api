using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class UserSubscriptionProduct
    {
        public string Id { get; set; }
        public string? ProductId { get; set; }
        public string? CustomProductId { get; set; }
        public string? SelectOptionId { get; set; }
        public string? CustomSelectOptionId { get; set; }        
        public string UserSubscriptionId { get; set; }
        public bool Deleted { get; set; } = false;
        public SelectOption SelectOption { get; set; }
        public CustomSelectOption CustomSelectOption { get; set; }
        public Product Product { get; set; }
        public CustomProduct CustomProduct { get; set; }
        public UserSubscription UserSubscription { get; set; }
        public ICollection<UserSubscriptionMixCategory> SubscriptionMixCategories { get; set; }
    }
}
