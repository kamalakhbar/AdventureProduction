using System;
using System.Collections.Generic;

#nullable disable

namespace Production.Entities.Models
{
    public partial class Product
    {
        public Product()
        {
            BillOfMaterialComponents = new HashSet<BillOfMaterial>();
            BillOfMaterialProductAssemblies = new HashSet<BillOfMaterial>();
            ProductCostHistories = new HashSet<ProductCostHistory>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductListPriceHistories = new HashSet<ProductListPriceHistory>();
            ProductProductPhotos = new HashSet<ProductProductPhoto>();
            ProductReviews = new HashSet<ProductReview>();
            TransactionHistories = new HashSet<TransactionHistory>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool? MakeFlag { get; set; }
        public bool? FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int? ProductSubcategoryID { get; set; }
        public int? ProductModelID { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        public virtual UnitMeasure SizeUnitMeasureCodeNavigation { get; set; }
        public virtual UnitMeasure WeightUnitMeasureCodeNavigation { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterialComponents { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterialProductAssemblies { get; set; }
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
