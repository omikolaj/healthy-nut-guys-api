using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class IngredientViewModel
    {
        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MixCategoryId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool InStock { get; set; }
    }
}
