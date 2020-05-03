using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.Models
{    
    public class Cart
    {
        public string Id { get; set; }
        public string ApplicationUserId { get; set; }
        public bool Abandoned { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string IpAddress { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
