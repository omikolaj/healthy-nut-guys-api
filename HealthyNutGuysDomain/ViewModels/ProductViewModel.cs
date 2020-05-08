using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class ProductViewModel
    {
        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CategoryId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Subtitle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ImageSrc { get; set; }        
        [DataMember(EmitDefaultValue = false)]
        public bool IsOnSale { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool IsInStock { get; set; }
        [DataMember(EmitDefaultValue = false)]        
        public ICollection<SaleItemViewModel> Sales { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CategoryViewModel Category { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<ProductDetailsViewModel> ProductDetails { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<TagViewModel> Tags { get; set; }
    }
}
