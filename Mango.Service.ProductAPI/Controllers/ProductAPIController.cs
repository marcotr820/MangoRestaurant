using Mango.Service.ProductAPI.Models.Dto;
using Mango.Service.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Service.ProductAPI.Controllers
{
   [Route("api/products")]
   public class ProductAPIController : Controller
   {
      protected ResponseDto _response;
      private IProductRepository _productRepository;

      public ProductAPIController(IProductRepository productRepository)
      {
         _response = new ResponseDto();
         _productRepository = productRepository;
      }

      [HttpGet]
      public async Task<ResponseDto> Get()
      {
         try
         {
            IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
            _response.Result = productDtos;
         }
         catch (Exception ex)
         {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() { ex.ToString() };
         }

         return _response;
      }

      [HttpGet]
      [Route("{id}")]
      public async Task<ResponseDto> GetById(int id)
      {
         try
         {
            ProductDto productDto = await _productRepository.GetProductById(id);
            _response.Result = productDto;
         }
         catch (Exception ex)
         {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() { ex.ToString() };
         }

         return _response;
      }

      [HttpPost]
      public async Task<ResponseDto> Post([FromBody] ProductDto productDto)
      {
         try
         {
            ProductDto model = await _productRepository.CreateUpdateProduct(productDto);
            _response.Result = model;
         }
         catch (Exception ex)
         {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() { ex.ToString() };
         }

         return _response;
      }

      [HttpPut]
      public async Task<ResponseDto> Put([FromBody] ProductDto productDto)
      {
         try
         {
            ProductDto model = await _productRepository.CreateUpdateProduct(productDto);
            _response.Result = model;
         }
         catch (Exception ex)
         {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() { ex.ToString() };
         }

         return _response;
      }

      [HttpDelete]
      [Route("{id}")]
      public async Task<ResponseDto> Delete(int id)
      {
         try
         {
            bool isSuccess = await _productRepository.DeleteProduct(id);
            _response.Result = isSuccess;
         }
         catch (Exception ex)
         {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() { ex.ToString() };
         }

         return _response;
      }
   }
}
