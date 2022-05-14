using System;
using System.Collections.Generic;

#nullable disable

namespace ProductionWebApi.Models
{
    public partial class vSearchProduct
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public short SafetyStockLevel { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string SubCategory { get; set; }
        public string Category { get; set; }
        public int DaysToManufacture { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
    }
}
