using Production.Entities.Models;
using Production.Entities.RequestFeatures;
using ProductionWebApi.Models;
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
        Task<IEnumerable<vSearchProduct>> SearchProduct(ProductParameters productParameters, bool trackChanges);
//        Task<IEnumerable<vAddProductt>> AddProductts(bool trackChanges);
        //void CreateProductAsync(Product product);
        //void DeleteProductAsync(Product product);
        //void UpdateProductAsync(Product product);
    }
}
