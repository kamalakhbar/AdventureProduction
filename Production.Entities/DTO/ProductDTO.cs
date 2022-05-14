using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Entities.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public short SafetyStockLevel { get; set; }
        public decimal StandartCost { get; set; }
        public decimal ListPrice { get; set; }
        public string SubCategory { get; set; }
        public string Category { get; set; }
        public int DaystoManufacture { get; set; }
        public bool? DiscontinuedDate { get; set; }
//        public
    }
}
