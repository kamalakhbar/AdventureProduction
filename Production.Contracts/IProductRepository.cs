using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        Task<Product> GetProductByNameAsync(string Name, bool trackChanges);
        Task<Product> GetProductByProductNumberAsync(string ProductNumber, bool trackChanges);
        //Task<ProductSubcategory> GetProductBySubCategoryIDAsync(int ProductSubCategoryID, bool trackChanges);
        void CreateProductAsync(Product product);
        void DeleteProductAsync(Product product);
        void UpdateProductAsync(Product product);
    }
}
