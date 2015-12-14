using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KPI.BusinessObjects
{
    [DataContract]
    public class ProductDto
    {
        [DataMember(Name="id")]
        public int ProductId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "active")]
        public bool Active { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "metaKeyWords")]
        public string MetaKeywords { get; set; }

        [DataMember(Name = "metaDescription")]
        public string MetaDescription { get; set; }

        [DataMember(Name = "metaTitle")]
        public string MetaTitle { get; set; }

        [DataMember(Name = "displayOrder")]
        public int? DisplayOrder { get; set; }

        [DataMember(Name = "deleted")]
        public bool Deleted { get; set; }

        [DataMember(Name = "imagePath")]
        public string ImagePath { get; set; }
    }
}
