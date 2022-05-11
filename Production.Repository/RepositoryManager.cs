using Production.Contracts;
using Production.Entities.AdventureContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureContext _adventureContext;
        private IProductRepository _productRepository;

        public RepositoryManager(AdventureContext adventureContext)
        {
            _adventureContext = adventureContext;
        }




        //membuat objek ke memory... stiap program ada konstruktor, 
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_adventureContext);
                }
                return _productRepository;
            }
        }

        public void Save()
        {
            _adventureContext.SaveChanges();
        }


        public async Task SaveAsync()
        {
            await _adventureContext.SaveChangesAsync();
        }
    }
}
