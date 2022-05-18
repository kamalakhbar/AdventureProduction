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
        //private IAddProduct _addProduct;
        private IAddProd _addProd;
       // private ICOBA _coba;
       // private IBARU _baru;
      // private I
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

        //public IAddProduct AddProduct
        //{
        //    get
        //    {
        //        if (_addProduct == null)
        //        {
        //            _addProduct = new AddProductRepository(_adventureContext);
        //        }
        //        return _addProduct;
        //    }
        //}

        

        public IAddProd ProdukBaru
        {
            get
            {
                if (_addProd == null)
                {
                    _addProd = new AddProd(_adventureContext);
                }
                return _addProd;
            }
        }


        //public ICOBA Nyoba
        //{
        //    get
        //    {
        //        if (_coba == null)
        //        {
        //            _coba = new COBA(_adventureContext);
        //        }
        //        return _coba;
        //    }
        //}



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
