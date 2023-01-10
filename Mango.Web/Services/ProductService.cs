using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
   public class ProductService : BaseService, IProductService
   {
      private readonly IHttpClientFactory _clientFactory;

      public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
      {
         _clientFactory = clientFactory;
      }

      public async Task<T> CreateProductAsync<T>(ProductDto productDto)
      {
         //llamamos al metodo SendAsync por que estamos heredando de BaseService
         return await this.SendAsync<T>(new ApiRequest()
         {
            ApiType = SD.ApiType.POST, //metodo que usaremos
            Data = productDto,
            Url = SD.ProductAPIBase + "/api/products",   //llamamos a la api
            AccessToken = ""
         });
      }

      public async Task<T> DeleteProductAsync<T>(int id)
      {
         //llamamos al metodo SendAsync por que estamos heredando de BaseService
         return await this.SendAsync<T>(new ApiRequest()
         {
            ApiType = SD.ApiType.DELETE,  //metodo que usaremos
            Url = SD.ProductAPIBase + "/api/products/"+id,   //llamamos a la api
            AccessToken = ""
         });
      }

      public async Task<T> GetAllProductsAsync<T>()
      {
         //llamamos al metodo SendAsync por que estamos heredando de BaseService
         return await this.SendAsync<T>(new ApiRequest()
         {
            ApiType = SD.ApiType.GET,  //metodo que usaremos
            Url = SD.ProductAPIBase + "/api/products",   //llamamos a la api
            AccessToken = ""
         });
      }

      public async Task<T> GetProductByIdAsync<T>(int id)
      {
         //llamamos al metodo SendAsync por que estamos heredando de BaseService
         return await this.SendAsync<T>(new ApiRequest()
         {
            ApiType = SD.ApiType.GET,  //metodo que usaremos
            Url = SD.ProductAPIBase + "/api/products/"+id,   //llamamos a la api
            AccessToken = ""
         });
      }

      public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
      {
         //llamamos al metodo SendAsync por que estamos heredando de BaseService
         return await this.SendAsync<T>(new ApiRequest()
         {
            ApiType = SD.ApiType.PUT,  //metodo que usaremos
            Data = productDto,
            Url = SD.ProductAPIBase + "/api/products",   //llamamos a la api
            AccessToken = ""
         });
      }
   }
}
