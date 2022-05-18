using AutoMapper;
using Production.Contracts;
using Production.Entities.DTO;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Repository
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public Task<ProductModel> AddNameModel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductSubcategory> AddSubCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddToCart(AddProductDTO addProductDTO)
        {
            try
            {
                var cart = await _repositoryManager.ProdukBaru.GetProductByID(addProductDTO.ProductID, trackChanges: true);
                if (cart ==null)
                {
                    Product product = new Product();
                    product.Name = addProductDTO.Name;
                    product.ProductNumber = addProductDTO.ProductNumber;
                    product.Color = addProductDTO.Color;
                    product.SafetyStockLevel = addProductDTO.SafelyStockLevel;
                    product.ListPrice = addProductDTO.ListPrice;
                    product.StandardCost = addProductDTO.StandartCost;
                    product.Size = addProductDTO.Size;
                    product.SizeUnitMeasureCode = addProductDTO.unitMeasure;
                    product.WeightUnitMeasureCode = addProductDTO.WeightType;
                    product.Weight = addProductDTO.Weight;
                    product.DaysToManufacture = addProductDTO.DaytoManufacture;
                    product.ProductLine = addProductDTO.ProductLine;
                    product.Class = addProductDTO.Class;
                    product.Style = addProductDTO.Style;
                    product.ProductSubcategoryID = addProductDTO.SubCategoryID;
                    product.ProductModelID = addProductDTO.ProductModelID;
                    product.MakeFlag = addProductDTO.MakeFlag;
                    product.FinishedGoodsFlag = addProductDTO.FinishedFlag;
                    product.SellStartDate = addProductDTO.SellStartDate;
                    product.SellEndDate = addProductDTO.SellEndDate;
                    product.DiscontinuedDate = addProductDTO.Discontinue;
                    _repositoryManager.ProdukBaru.Create(product);
                    await _repositoryManager.SaveAsync();
                }
                return true;
            }
            catch (Exception w)
            {
                _logger.LogInfo($"{w.Message}");
                return false;
            }
        }

        public Task<IEnumerable<Product>> GetProductById(bool trackChanges)
        {
            throw new NotImplementedException();
            //IEnumerable<Product> products1 = null;
            //try
            //{
            //    IEnumerable<Product> products = _repositoryManager.ProductRepository.(trackChanges: false);
            //    return Tuple.Create(1, products, "Suksses");
            //}
            //catch (Exception e)
            //{
            //    return Tuple.Create(-1, products1, e.Message);
            //}
        }
    }
}
