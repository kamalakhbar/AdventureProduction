using System;
using System.Collections.Generic;

#nullable disable

namespace Production.Entities.Models
{
    public partial class ProductSubcategory
    {
        public ProductSubcategory()
        {
            Products = new HashSet<Product>();
        }

        public int ProductSubcategoryID { get; set; }
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
