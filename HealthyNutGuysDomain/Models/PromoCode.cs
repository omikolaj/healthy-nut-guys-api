using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class PromoCode
    {
        public string Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Code canno't be longer than 10 digits")]
        public string Code { get; set; }
        public bool Deleted { get; set; } = false;
        [Required]
        public DateTime ExpireDate { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal DiscountValue { get; set; }
        [Required]
        public OfferType Type { get; set; }
    }
}
