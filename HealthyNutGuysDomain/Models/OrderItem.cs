using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class OrderItem
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string ProductDetailsId { get; set; }
        public string Quantity { get; set; }
        public bool Deleted { get; set; } = false;
        public ProductDetails ProductDetails { get; set; }
        public Order Order { get; set; }
    }
}
