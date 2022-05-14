using System;
using System.Collections.Generic;

#nullable disable

namespace Production.Entities.Models
{
    public partial class vAddProduct
    {
        public int ProductID { get; set; }
        public string Nama_Produk { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public decimal ListPrice { get; set; }
        public decimal StandardCost { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string SubName { get; set; }
        public string Model_Name { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
    }
}
