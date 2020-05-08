using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class ProductDetails
    {
        public string Id { get; set; }
        public string ProductId { get; set; }        
        public string LabelSrc { get; set; }
        public bool Deleted { get; set; } = false;
        public SelectOption SelectOption { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal SalePrice { get; set; }
        public Product Product { get; set; }
    }
}
