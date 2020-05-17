using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class UserSubscription
    {
        public string Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string SubscriptionOfferId { get; set; }
        public DateTime NextDelivery { get; set; }
        public DateTime Modified { get; set; }
        public Frequency Frequency { get; set; }
        public bool Deleted { get; set; } = false;
        public SubscriptionOffer SubscriptionOffer { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<SpecialOffer> SpecialOffers { get; set; }
        public ICollection<UserSubscriptionProduct> UserSubscriptionProducts { get; set; }
    }
}
