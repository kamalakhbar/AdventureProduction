using Production.Entities.DTO;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Contracts
{
    public interface IAddProduct
    {
        Task<IEnumerable<vAddProduct>> CreateProduct(AddProductDTO addProductDTO,bool trackChanges);
        Task<vAddProduct> GetProductByNumberProduct(int productNumber, bool trackChanges);
        Tuple<int, Product, string> AddtoProduct(AddProductDTO addProductDTO, bool trackChanges);
        //void CreateProduct(Product product);
    }
}
