using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Discount
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal DiscountValue { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
