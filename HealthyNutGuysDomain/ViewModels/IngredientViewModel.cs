using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class IngredientViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MixCategoryId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public bool InStock { get; set; }
    }
}
