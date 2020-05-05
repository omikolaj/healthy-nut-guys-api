using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SubscriptionOffer
    {
        public string Id { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal DiscountValue { get; set; }
        public string? SpecialOfferId { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? StartDate { get; set; }        
        public Frequency Frequency { get; set; }
        public bool? Deleted { get; set; } = false;
        public OfferType Type { get; set; }        
        public bool StandardOffer { get; set; } = true;
        public SpecialOffer SpecialOffer { get; set; }
    }
}
