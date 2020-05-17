using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class CustomSelectOptionViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CustomProductId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Option { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public decimal Price { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public decimal SalePrice { get; set; }
    }
}
