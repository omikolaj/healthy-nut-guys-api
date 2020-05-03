using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Models
{
    public class SpecialOffer
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public DateTime ExpireDate { get; set; }
        // free shipping vs free stickers
        public int Type { get; set; }
        public string OfferValue { get; set; }
        // store wide or individual item
        public int Scope { get; set; }                
        public Product Product { get; set; }
    }
}
