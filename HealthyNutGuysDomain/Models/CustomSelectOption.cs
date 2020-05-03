using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSelectOption
    {
        public string Id { get; set; }
        public string Option { get; set; }
        public string CustomSackDetailsId { get; set; }
        public CustomSackDetails CustomSackDetails { get; set; }
    }
}
