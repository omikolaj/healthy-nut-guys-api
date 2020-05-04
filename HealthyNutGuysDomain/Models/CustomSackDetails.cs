using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSackDetails
    {
        public string Id { get; set; }
        public string MixCategoryId { get; set; }
        public string CustomSackId { get; set; }
        public MixCategory MixCategory { get; set; }        
        public CustomSack CustomSack { get; set; }
    }
}
