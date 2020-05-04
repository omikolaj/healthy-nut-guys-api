using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string DiscountId { get; set; }
        public string AddressId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; }
        public bool? Deleted { get; set; } = false;
        public int Status { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Amount { get; set; }
        public Address Address { get; set; }
        public Discount Discount { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<OrderItem> OrerItems { get; set; }
    }
}
