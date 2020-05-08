using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSelectOption
    {
        public string Id { get; set; }
        public string Option { get; set; }
        public string CustomProductId { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal SalePrice { get; set; }
        public CustomProduct CustomProduct { get; set; }
    }
}
