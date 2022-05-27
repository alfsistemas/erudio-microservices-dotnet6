using AutoMapper;
using GeekShopping.ProductAPI.Data.ValuesObject;
using GeekShopping.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
