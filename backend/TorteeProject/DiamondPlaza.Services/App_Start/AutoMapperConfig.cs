using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace DiamondPlaza.Services
{
    public static class AutoMapperConfig
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
             
        }
    }
}
