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
        public DateTime? ExpireDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool LimitedTimeOffer { get; set; } = false;
        public bool StandardOffer { get; set; } = true;        
    }
}
