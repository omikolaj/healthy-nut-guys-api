using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract]
    public class UserSubscriptionProductViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CustomSelectOptionViewModel CustomSelectOption { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CustomProductViewModel CustomProduct { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public SelectOptionViewModel SelectOption { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ProductViewModel Product { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<UserSubscriptionMixCategoryViewModel> SubscriptionMixCategories { get; set; }
    }
}
