using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSackDetails
    {
        public string Id { get; set; }
        public string MixCategoryId { get; set; }
        public string ProductId { get; set; }
        public MixCategory MixCategory { get; set; }
        public ICollection<CustomSelectOption> SelectOptions { get; set; }        
    }
}
