using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool? Deleted { get; set; } = false;
        public ICollection<Product> Products { get; set; }
    }
}
