using TemplateAPI.WebApi.Configuration;
using TemplateAPI.WebApi.Configurations;

namespace TemplateAPI.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureServices(builder);
            AddConnections();
            ConfigureApplication(builder.Build(), builder.Configuration);
        }

        /// <summary>
        /// Adiciona as licensas e connections strings aos projetos
        /// </summary>
        private static void AddConnections()
        {

        }

        /// <summary>
        /// Retorna o conteudo de um json especifico, normalmente appSettinhs.json
        /// </summary>
        /// <param name="pathDirectory">Caminho do Diretorio</param>
        /// <param name="jsonNome">Nome do arquivo json</param>
        /// <param name="section">Nome do valor que deseja buscar</param>
        /// <returns></returns>
        private static string GetConfigurationBuilder(string pathDirectory, string jsonNome, string section)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
                                .SetBasePath(pathDirectory)
                                .AddJsonFile(jsonNome)
                                .Build();

            return Configuration[section];
        }

        /// <summary>
        /// Adiciona os serviços ao builder
        /// </summary>
        /// <param name="builder"></param>
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            //Adiciona as configurações do swagger
            builder.Services.AddSwaggerConfiguration();

            //Injeções de dependencia do projeto IOC
            builder.Services.AddDependencyInjectionConfiguration(builder.Configuration);

            //Injeções do auto mapper
            builder.Services.AddDAutoMapperInjectionConfiguration();
        }

        /// <summary>
        /// Configuração do webApplication, descomente o que for necessário
        /// </summary>
        /// <param name="app"></param>
        public static void ConfigureApplication(WebApplication app, IConfiguration configuration)
        {
            // Mova para ca os metodos que só serão utilizados em ambiente de desenvolvimento. 
            // Após configurar o Swagger mova app.UseSwaggerSetup(configuration); para dentro do if
            if (app.Environment.IsDevelopment())
            {

            }

            app.UseSwaggerSetup(configuration);

            // app.UseCors("AllowAllOrigins");

            // app.UseHttpsRedirection();

            // app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

    }
}
