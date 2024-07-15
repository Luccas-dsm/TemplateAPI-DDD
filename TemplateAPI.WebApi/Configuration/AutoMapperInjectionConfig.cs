using TemplateAPI.Service.Mapper;

namespace TemplateAPI.WebApi.Configurations
{
    public static class AutoMapperInjectionConfig
    {
        public static void AddDAutoMapperInjectionConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MapperProfile()));
        }
    }
}
