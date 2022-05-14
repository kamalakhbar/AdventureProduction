using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Entities.DTO
{
    public class AddProductDTO
    {
        //public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string? Color { get; set; }
        public int SafelyStockLevel { get; set; }
        public decimal ListPrice { get; set; }
        public decimal StandartCost { get; set; }
        public string? Size { get; set; }
        public string? unitMeasure { get; set; }
        public string? WeightType { get; set; }
        public float Weight { get; set; }
        public int DaytoManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int SubCategoryID { get; set; }
        public int ProductModelID { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedFlag { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime Discontinue { get; set; }
    }
}
