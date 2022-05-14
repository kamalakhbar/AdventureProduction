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
    public class AddProductRepository : RepositoryBase<vAddProduct>, IAddProduct
    {
        private readonly IRepositoryManager _repository;
        public AddProductRepository(AdventureContext adventure) : base(adventure)
        {

        }

        public Tuple<int, Product, string> AddtoProduct(AddProductDTO addProductDTO, bool trackChanges)
        {
            //Product product = new Product();
            //ProductSubcategory productSubcategory = new ProductSubcategory();
            //ProductModel productModel = new ProductModel();
            //try
            //{
            //    product = _repository.AddProduct.CreateProduct(addProductDTO, trackChanges: true);

            //}
            //catch
            //{
            //}
            throw new NotImplementedException();
        }

        public Task<IEnumerable<vAddProduct>> CreateProduct(AddProductDTO addProductDTO, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<vAddProduct> GetProductByNumberProduct(int productNumber, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
