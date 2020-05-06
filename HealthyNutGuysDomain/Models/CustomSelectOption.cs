using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSelectOption
    {
        public string Id { get; set; }
        public string Option { get; set; }
        public string CustomProductId { get; set; }
        public CustomProduct CustomProduct { get; set; }
    }
}
