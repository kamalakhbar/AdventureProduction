using Production.Entities.DTO;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Contracts
{
    public interface IAddProd
    {
        Task<IEnumerable<Product>> GetAllProd(AddProductDTO addProductDTO, bool trackChanges);
        Task<Product> GetProductByID(int ProdID, bool trackChanges);
        
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
