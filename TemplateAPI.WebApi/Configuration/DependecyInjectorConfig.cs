using TemplateAPI.Ioc.DependecyInjector;

namespace TemplateAPI.Configuration
{
    public static class DependecyInjectorConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            DependecyInjector.Register(services, configuration);
        }
    }
}
