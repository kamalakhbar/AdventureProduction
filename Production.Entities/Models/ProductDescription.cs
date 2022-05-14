using System;
using System.Collections.Generic;

#nullable disable

namespace Production.Entities.Models
{
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        public int ProductDescriptionID { get; set; }
        public string Description { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}
