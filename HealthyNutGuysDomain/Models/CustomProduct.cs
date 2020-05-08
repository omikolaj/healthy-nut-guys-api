using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class CustomProduct
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Subtitle { get; set; }        
        public string ImageSrc { get; set; }
        [Required]
        public CustomProductType Type { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal? Price { get; set; }
        public bool IsInStock { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public bool IsOnSale { get; set; } = false;        
        // if the item is on sale 
        public ICollection<SaleItem> Sales { get; set; }
        public Category Category { get; set; }
        public ICollection<MixCategory> MixCategories { get; set; }
        public ICollection<Tag> Tags { get; set; }        
        public ICollection<CustomSelectOption> SelectOptions { get; set; }
    }
}
