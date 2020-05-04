using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomSack
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Subtitle { get; set; }
        public string ImageSrc { get; set; }        
        [Column(TypeName = "decimal(5,2)")]
        public decimal? Price { get; set; }
        public bool? IsOnSale { get; set; }        
        // if the item is on sale 
        public SaleItem SaleItem { get; set; }
        public Category Category { get; set; }
        public ICollection<MixCategory> MixCategories { get; set; }
        public ICollection<Tag> Tags { get; set; }
        // if the item has special offers
        public ICollection<SpecialOffer> SpecialOffers { get; set; }
        public ICollection<CustomSelectOption> SelectOptions { get; set; }
    }
}
