using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Tag
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
