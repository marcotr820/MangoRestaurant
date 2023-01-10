using AutoMapper;
using Mango.Service.ProductAPI.Models;
using Mango.Service.ProductAPI.Models.Dto;

namespace Mango.Service.ProductAPI.Mapping
{
   public class MappingConfig
   {
      //los metodos o propiedades estatidoc pueden ser usados directamente sin estar
      //instanciando la clase
      public static MapperConfiguration RegisterMaps()
      {
         var mappingConfig = new MapperConfiguration(config =>
         {
            config.CreateMap<ProductDto, Product>();
            config.CreateMap<Product, ProductDto>();
         });

         return mappingConfig;
      }
   }
}
