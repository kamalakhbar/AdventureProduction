using System;
using System.Collections.Generic;

#nullable disable

namespace Production.Entities.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubcategories = new HashSet<ProductSubcategory>();
        }

        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }
    }
}
