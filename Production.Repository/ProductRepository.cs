using Microsoft.EntityFrameworkCore;
using Production.Contracts;
using Production.Entities.AdventureContexts;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Northwind.Entities.RequestFeature;

namespace Production.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(AdventureContext adventure) : base(adventure)
        {

        }

        public void CreateProductAsync(Product product)
        {
            Create(product);
        }

        public void DeleteProductAsync(Product product)
        {
            Delete(product);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
              .OrderBy(x => x.ProductID)
              .ToListAsync();
        }

        public async Task<Product> GetProductByNameAsync(string productName, bool trackChanges)
        => await FindByCondition(x => x.Name.Equals(productName), trackChanges).SingleOrDefaultAsync();


        public async Task<Product> GetProductByProductNumberAsync(string ProductNumber, bool trackChanges)
        {
            return await FindByCondition(x => x.ProductNumber.Equals(ProductNumber), trackChanges).SingleOrDefaultAsync();
        }

        //public Task<ProductSubcategory> GetProductBySubCategoryIDAsync(int ProductSubCategoryID, bool trackChanges)
        //{
        //    throw new NotImplementedException();
        //}

        public void UpdateProductAsync(Product product)
        {
            Update(product);
        }
    }
}
