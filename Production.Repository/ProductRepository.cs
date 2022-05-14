using Microsoft.EntityFrameworkCore;
using Production.Contracts;
using Production.Entities.AdventureContexts;
using Production.Entities.Models;
using Production.Entities.RequestFeatures;
using ProductionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Northwind.Entities.RequestFeature;

namespace Production.Repository
{
    public class ProductRepository : RepositoryBase<vSearchProduct>, IProductRepository
    {
        public ProductRepository(AdventureContext adventure) : base(adventure)
        {

        }

        public Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        //public Task<IEnumerable<vAddProductt>> AddProductts(bool trackChanges)
        //{

        //}

        //public void CreateProductAsync(Product product)
        //{
        //    Create(product);
        //}

        //public void DeleteProductAsync(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<vSearchProduct>> SearchProduct(ProductParameters productParameters, bool trackChanges)
        {
            if (string.IsNullOrWhiteSpace(productParameters.SearchProduct))
            {
                return await FindAll(trackChanges).ToListAsync();
            }
            var lowerCaseSearch = productParameters.SearchProduct.Trim().ToLower();

            return await FindAll(trackChanges)
                .Where(c => c.Name.ToLower().Contains(lowerCaseSearch) ||
                        c.ProductNumber.ToLower().Contains(lowerCaseSearch) ||
                        c.Category.ToLower().Contains(lowerCaseSearch) ||
                        c.SubCategory.ToLower().Contains(lowerCaseSearch))
                .OrderBy(c => c.Name).ThenByDescending(c => c.SafetyStockLevel)
                .Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
                .Take(productParameters.PageSize)
                .ToListAsync();
        }

        public void UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        /* public void CreateProductAsync(Product product)
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

         public async Task<IEnumerable<vSearchProduct>> SearchProduct(ProductParameters productParameters, bool trackChanges)
         {
             if (string.IsNullOrWhiteSpace(productParameters.SearchProduct))
             {
                 return await FindAll(trackChanges).ToListAsync();
             }
             var lowerCaseSearch = productParameters.SearchProduct.Trim().ToLower();

             return await FindAll(trackChanges)
                 .Where(c => c.Name.ToLower().Contains(lowerCaseSearch) || 
                         c.ProductNumber.ToLower().Contains(lowerCaseSearch))
                 .OrderBy(c => c.Name)
                 .Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
                 .Take(productParameters.PageSize)
                 .ToListAsync();
         }

         public void UpdateProductAsync(Product product)
         {
             Update(product);
         }*/
    }
}
