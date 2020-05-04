using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SelectOption
    {
        public string Id { get; set; }
        public string Option { get; set; }
        public string ProductDetailsId { get; set; }
        public bool? Deleted { get; set; } = false;
        public ProductDetails ProductDetails { get; set; }
    }
}
