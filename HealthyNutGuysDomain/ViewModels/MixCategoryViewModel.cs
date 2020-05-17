using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class MixCategoryViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]        
        public string CustomProductId { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public bool InStock { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public int Order { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public MixCategoryType Type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<IngredientViewModel> Ingredients { get; set; }

    }
}
