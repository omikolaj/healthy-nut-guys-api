using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract]
    public class UserSubscriptionMixCategoryIngredientViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = true)]
        public int Weight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public IngredientViewModel Ingredient { get; set; }        
    }
}
