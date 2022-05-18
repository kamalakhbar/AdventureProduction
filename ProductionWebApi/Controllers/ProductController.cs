using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Production.Contracts;
using Production.Entities.DTO;
using Production.Entities.Models;
using Production.Entities.RequestFeatures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductionWebApi.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IServiceManager _serviceManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IServiceManager serviceManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _serviceManager = serviceManager;   
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                var product = await _repository.ProductRepository.GetAllProductsAsync(trackChanges: false);
                var productDTO = _mapper.Map<IEnumerable<ProductDTO>>(product);
                return Ok(productDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(GetAllProduct)} message {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("Search")]
        public async Task<IActionResult> SearchProduct([FromQuery] ProductParameters productParameters)
        {
            var productSearch = await _repository.ProductRepository.SearchProduct(productParameters, trackChanges: false);
            var productDTO = _mapper.Map<IEnumerable<ProductDTO>>(productSearch);
            return Ok(productDTO);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> PostCustomer([FromBody] AddProductDTO addProductDTO)
        {
            var prodd = await _serviceManager.AddToCart(addProductDTO);
            if (!prodd)
            {
                _logger.LogError("ERROR");
                return BadRequest();
            }
            var productDTO = _mapper.Map<IEnumerable<AddProductDTO>>(prodd);
            return Ok(productDTO);            //if (addProductDTO == null)
            //{
            //    _logger.LogError("PRODUCT IS NULL");
            //    return BadRequest("PRODUCT IS NULL");
            //}
            ////objek modelstate digunakan utk memvalidasi daata yg di tangkap oleh customerDTO
            //if (!ModelState.IsValid)
            //{
            //    _logger.LogError("Invalid Modelstate");
            //    return UnprocessableEntity(addProductDTO);
            //}
            //var ProdEntity = _mapper.Map<Product>(addProductDTO);
            //_repository.Nyoba.Create(ProdEntity);
            //await _repository.SaveAsync();

            //var ProductToReturn = _mapper.Map<AddProductDTO>(ProdEntity);
            //return CreatedAtAction("Product ID ", new { id = ProductToReturn.ProductID }, ProductToReturn);
        }

    }
}
