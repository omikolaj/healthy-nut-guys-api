using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CartItem
    {
        public string Id { get; set; }
        public string CartId { get; set; }
        public string ProductDetailsId { get; set; }
        public ProductDetails PropductDetails { get; set; }
        public int Quantity { get; set; }
        public bool SavedForLater { get; set; } = false;
        public bool? Deleted { get; set; } = false;
        public DateTime TimeAdded { get; set; }
    }
}
