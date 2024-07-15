using TemplateAPI.Ioc.DependecyInjector;

namespace TemplateAPI.WebApi.Configuration
{
    public static class DependecyInjectorConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            DependecyInjector.Register(services, configuration);
        }
    }
}
