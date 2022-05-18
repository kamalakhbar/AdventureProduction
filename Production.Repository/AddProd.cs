using Microsoft.EntityFrameworkCore;
using Production.Contracts;
using Production.Entities.AdventureContexts;
using Production.Entities.DTO;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Repository
{
    public class AddProd : RepositoryBase<Product>, IAddProd
    {
        public AddProd(AdventureContext adventure) : base(adventure)
        {
        }



        public Task<IEnumerable<Product>> GetAllProd(AddProductDTO addProductDTO, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductByID(int ProdID, bool trackChanges)
        => await FindByCondition(x => x.ProductID.Equals(ProdID), trackChanges).SingleOrDefaultAsync();
        

        //public Product GetProductByID(int ProdID, bool trackChanges) 

        void IAddProd.Create(Product product)
        {
            Create(product);
        }

        void IAddProd.Delete(Product product)
        {
            Delete(product);
        }

        

        void IAddProd.Update(Product product)
        {
            Update(product);
        }
    }
}
