using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract]
    public class UserSubscriptionMixCategoryViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public MixCategoryViewModel MixCategory { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<UserSubscriptionMixCategoryIngredientViewModel> Ingredients { get; set; }
    }
}
