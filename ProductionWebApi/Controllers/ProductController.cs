using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Production.Contracts;
using Production.Entities.DTO;
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
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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

        [HttpGet("ProdName", Name = "ProductNameAsync")]
        public async Task<IActionResult> GetProductByNameAsync(string productName)
        {
            var product = await _repository.ProductRepository.GetProductByNameAsync(productName, trackChanges: false);
            if (product == null)
            {
                _logger.LogInfo($"product with name {productName} NOT FOUND");
                return NotFound();
            }
            else
            {
                var productDTO = _mapper.Map<ProductDTO>(product);
                return Ok(productDTO);
            }
        }

        [HttpGet("ProdNumb", Name = "ProductNumberAsync")]
        public async Task<IActionResult> GetProductByNumberAsync(string productNumber)
        {
            var product = await _repository.ProductRepository.GetProductByProductNumberAsync(productNumber, trackChanges: false);
            if (product == null)
            {
                _logger.LogInfo($"product with name {productNumber} NOT FOUND");
                return NotFound();
            }
            else
            {
                var productDTO = _mapper.Map<ProductDTO>(product);
                return Ok(productDTO);
            }
        }

        //[HttpGet("pagination")]
        //public async Task<IActionResult> 
    }
}
