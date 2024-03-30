using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using TemplateAPI.Service.Validator.Base;

namespace TemplateAPI.Ioc.DependecyInjector
{
    public class DependecyInjector
    {

        public static void Register(IServiceCollection service)
        {
            AddService(service);
            AddDomain(service);
            AddRepository(service);
        }

        /// <summary>
        /// Injeções de dependencia relacionadas ao Service
        /// </summary>
        /// <param name="serviceCollection"></param>
        private static void AddService(IServiceCollection service)
        {

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
        /// Injeções de dependencia relacionadas ao Repository
        /// </summary>
        /// <param name="serviceCollection"></param>
        private static void AddRepository(IServiceCollection service)
        {

        }

    }
}
