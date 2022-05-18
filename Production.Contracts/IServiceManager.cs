using Production.Entities.DTO;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Contracts
{
    public interface IServiceManager
    {
        Task<IEnumerable<Product>> GetProductById(bool trackChanges);
        Task<ProductModel> AddNameModel(int id);
        Task<ProductSubcategory> AddSubCategory(int id);
        Task<bool> AddToCart(AddProductDTO addProductDTO);
    }
}
