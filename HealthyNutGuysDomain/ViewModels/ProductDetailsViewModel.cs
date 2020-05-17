using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class ProductDetailsViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ProductId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LabelSrc { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public SelectOptionViewModel SelectOption { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public decimal Price { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public decimal SalePrice { get; set; }
    }
}
