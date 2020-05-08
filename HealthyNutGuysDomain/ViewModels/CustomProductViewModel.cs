using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels
{
    [DataContract()]
    public class CustomProductViewModel
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
        public CustomProductType Type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal? Price { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool IsOnSale { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal SalePrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool IsInStock { get; set; }
        [DataMember(EmitDefaultValue = false)]
        // if the item is on sale 
        public ICollection<SaleItemViewModel> Sales { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CategoryViewModel Category { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<MixCategoryViewModel> MixCategories { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<TagViewModel> Tags { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ICollection<CustomSelectOptionViewModel> SelectOptions { get; set; }
    }
}
