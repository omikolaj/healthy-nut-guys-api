using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class SaleItemViewModel
    {
        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ProductId { get; set; }        
        [DataMember(EmitDefaultValue = false)]
        public DateTime ExpireDate { get; set; }        
        [DataMember(EmitDefaultValue = false)]
        public OfferType Type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal? DiscountValue { get; set; }        
    }
}
