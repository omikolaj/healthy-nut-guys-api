using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract]
    public class UserSubscriptionViewModel
    {
        [DataMember(EmitDefaultValue = true)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime NextDelivery { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime Modified { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Frequency Frequency { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<UserSubscriptionProductViewModel> UserSubscriptionProducts { get; set; }
    }
}
