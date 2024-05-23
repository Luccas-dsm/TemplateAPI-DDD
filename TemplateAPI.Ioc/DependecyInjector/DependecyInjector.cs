using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TemplateAPI.Domain.Service;
using TemplateAPI.Repository.ContextConfig;
using TemplateAPI.Repository.Repository;
using TemplateAPI.Service.Interfaces;
using TemplateAPI.Service.Service;
using TemplateAPI.Service.Validator.Base;

namespace TemplateAPI.Ioc.DependecyInjector
{
    public class DependecyInjector
    {

        public static void Register(IServiceCollection service, IConfiguration configuration)
        {
            AddService(service);
            AddDomain(service);
            AddRepository(service, configuration);
        }

        /// <summary>
        /// Injeções de dependencia relacionadas ao Service
        /// </summary>
        /// <param name="serviceCollection"></param>
        private static void AddService(IServiceCollection service)
        {
            service.AddScoped<IAreaConhecimentoService, AreaConhecimentoService>();
        }

        /// <summary>
        /// Injeções de dependencia relacionadas ao Domain
        /// </summary>
        /// <param name="serviceCollection"></param>
        private static void AddDomain(IServiceCollection service)
        {
            #region[validators]
            service.AddFluentValidationAutoValidation()
                       .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining(typeof(ValidatorBase<>)));

            #endregion
        }

        /// <summary>
        /// Retorna o conteudo de um json especifico, normalmente appSettinhs.json
        /// </summary>
        /// <param name="pathDirectory">Caminho do Diretorio</param>
        /// <param name="jsonNome">Nome do arquivo json</param>
        /// <param name="section">Nome do valor que deseja buscar</param>
        /// <returns></returns>
        private static string GetConfigurationBuilder(IConfiguration configuration, string pathDirectory, string jsonNome, string section)
        {
            configuration = new ConfigurationBuilder()
                                .SetBasePath(pathDirectory)
                                .AddJsonFile(jsonNome)
                                .Build();

            return configuration[section];
        }

        /// <summary>
        /// Injeções de dependencia relacionadas ao Repository
        /// </summary>
        /// <param name="serviceCollection"></param>
        private static void AddRepository(IServiceCollection service, IConfiguration Configuration)
        {
            var a = Configuration.GetConnectionString("Sql");
            service.AddDbContext<TemplateDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Sql")));
            service.AddScoped<IAreaConhecimentoRepository, AreaConhecimentoRepository>();

        }

    }
}
