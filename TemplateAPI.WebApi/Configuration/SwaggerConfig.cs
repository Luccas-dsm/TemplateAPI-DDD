using Microsoft.OpenApi.Models;

namespace TemplateAPI.WebApi.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = Directory.GetCurrentDirectory(),
                    Version = "v1",
                    Description = "Web api TemplateAPI",
                    //TermsOfService = new Uri("https://example.com/terms"),
                    //Contact = new OpenApiContact
                    //{
                    //    Name = "Shayne Boyer",
                    //    Email = string.Empty,
                    //    Url = new Uri("https://exemple.com/spboyer"),
                    //},
                    //License = new OpenApiLicense
                    //{
                    //    Name = "Use under LICX",
                    //    Url = new Uri("https://example.com/license"),
                    //}
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Por favor, insira o token JWT com a palavra 'Bearer' seguida de um espaço. Exemplo: 'Bearer {token}'.\n Obs: Para buscar o token utilize a rota de login.",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });

            });
        }

        //ATENÇÃO: Configure no AppSettings.json o DiretorioSwagger de acordo com a porta que está rodando a aplicação
        public static void UseSwaggerSetup(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();

            var diretorio = configuration.GetSection("DiretorioSwagger").Value;
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", " TemplateApi - v1"));
        }
    }
}
