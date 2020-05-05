using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class PromoCodeViewModel
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Code { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime ExpireDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal DiscountValue { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public OfferType Type { get; set; }
    }
}
