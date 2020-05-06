using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SaleItem
    {
        public string Id { get; set; }
        public string? ProductId { get; set; }
        public string? CustomProductId { get; set; }
        public string? PromoCodeId { get; set; }        
        public string? SpecialOfferId { get; set; }
        public bool Deleted { get; set; } = false;
        [Required]
        public DateTime ExpireDate { get; set; }
        // % vs $
        [Required]
        public OfferType Type { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal? DiscountValue { get; set; }
        public PromoCode PromoCode { get; set; }
        public SpecialOffer SpecialOffer { get; set; }
        public Product Product { get; set; }
        public CustomProduct CustomProduct { get; set; }

    }
}
