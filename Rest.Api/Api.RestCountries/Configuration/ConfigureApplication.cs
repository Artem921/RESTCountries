using Client.Service;
using Client.Services.Abstract;
using Client.Services.Interfaces;
using Microsoft.OpenApi.Models;

namespace Api.RestCountries.Configuration
{
    public static class ConfigureApplication
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ICountrieyService,CountryClient>();
            services.AddHttpClient<BaseClient>();
            services.AddEndpointsApiExplorer();
            services.AddControllers();
            services.AddAutoMapper(typeof(Program));
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "RestCountries API",
                    Description = "Country information",
                    Contact = new OpenApiContact
                    {
                        Name = "Restcountries",
                        Url = new Uri("https://restcountries.com/ ")
                    }
            
                });
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "RestApi.xml");
                options.IncludeXmlComments(xmlPath);

            });

        }
    }
}
