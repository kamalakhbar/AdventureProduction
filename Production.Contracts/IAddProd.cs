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
        Task<Product> GetProductByID(int ProdID, bool trackChanges);
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
