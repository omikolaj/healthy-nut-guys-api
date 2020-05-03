using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SaleItem
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public DateTime ExpireDate { get; set; }
        // % vs $
        public int Type { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal DiscountValue { get; set; }
        public Product Product { get; set; }        
    }
}
