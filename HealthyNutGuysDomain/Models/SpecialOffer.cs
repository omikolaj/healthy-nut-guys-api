using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SpecialOffer
    {
        public string Id { get; set; }
        public string? PromoCodeId { get; set; }
        public string? UserSubscriptionId { get; set; }
        public bool Deleted { get; set; } = false;
        public bool? AppliesNextOrder { get; set; }
        public string DisplayMessage { get; set; }
        // store wide vs specific to subscription offer, nullable because promo codes that point to special offers do not set scope
        [Required]
        public OfferScope Scope { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        // free shipping vs free stickers vs % off vs $ off
        [Required]
        public OfferType Type { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal? DiscountValue { get; set; }
        public PromoCode PromoCode { get; set; }
        public UserSubscription UserSubscription { get; set; }
    }
}
