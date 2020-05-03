using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace HealthyNutGuysDomain.Models
{
  public class ApplicationUser : IdentityUser
  {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Deleted { get; set; } = false;
        public UserSubscription Subscription { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}