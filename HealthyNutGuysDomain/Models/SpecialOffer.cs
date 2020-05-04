using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SpecialOffer
    {
        public string Id { get; set; }
        public string? PromoCodeId { get; set; }
        public string? UserSubscriptionId { get; set; }
        public bool? Deleted { get; set; } = false;
        public bool? AppliesNextOrder { get; set; }
        public DateTime ExpireDate { get; set; }
        // free shipping vs free stickers vs % off vs $ off
        public int Type { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal? DiscountValue { get; set; }
        public PromoCode PromoCode { get; set; }
        public UserSubscription UserSubscription { get; set; }
    }
}
