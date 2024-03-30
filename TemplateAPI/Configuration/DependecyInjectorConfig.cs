using TemplateAPI.Ioc.DependecyInjector;

namespace TemplateAPI.Configuration
{
    public static class DependecyInjectorConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            DependecyInjector.Register(services);
        }
    }
}
