using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSelectOption
    {
        public string Id { get; set; }
        public string Option { get; set; }
        public string CustomSackId { get; set; }
        public CustomSack CustomSack { get; set; }
    }
}
