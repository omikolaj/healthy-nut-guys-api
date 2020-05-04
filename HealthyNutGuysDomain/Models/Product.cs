﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Subtitle { get; set; }
        public string ImageSrc { get; set; }        
        [Column(TypeName = "decimal(5,2)")]
        public decimal? Price { get; set; }
        public bool? Deleted { get; set; } = false;
        public bool? IsOnSale { get; set; }
        // if the item is on sale 
        public ICollection<SaleItem> Sales { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductDetails> ProductDetails { get; set; }
        public ICollection<Tag> Tags { get; set; }   
    }
}