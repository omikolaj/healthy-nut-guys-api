using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class SelectOptionViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ProductDetailsId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Option { get; set; }
        
    }
}
