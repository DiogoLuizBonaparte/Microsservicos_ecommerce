using AutoMapper;
using LojaOnline.ProductAPI.Data.ValueObjects;
using LojaOnline.ProductAPI.Model;
namespace LojaOnline.ProductAPI.Config
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
