using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Address
    {
        public string Id { get; set; }        
        public string ApplicationUserId { get; set; }
        public string FullName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [StringLength(5, ErrorMessage = "PostCode cannot be longer than 5 digits")]
        public string PostCode { get; set; }
        public string City { get; set; }
        public bool? Deleted { get; set; } = false;
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
