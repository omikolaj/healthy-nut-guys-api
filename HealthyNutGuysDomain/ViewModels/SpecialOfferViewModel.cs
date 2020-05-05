using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class SpecialOfferViewModel
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string? PromoCodeId { get; set; }                
        [DataMember(EmitDefaultValue = false)]
        public bool? AppliesNextOrder { get; set; }
        // store wide vs specific to subscription offer, nullable because promo codes that point to special offers do not set scope
        [DataMember(EmitDefaultValue = false)]
        public OfferScope? Scope { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime ExpireDate { get; set; }
        // free shipping vs free stickers vs % off vs $ off
        [DataMember(EmitDefaultValue = false)]
        public OfferType Type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal? DiscountValue { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public PromoCodeViewModel PromoCode { get; set; }
    }
}
