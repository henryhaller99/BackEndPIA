using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>(); // con esta linea de codigo añadiremos los servicios de token a nuestra API
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            }); // en esta linea de codigo será la que se encargará de decirle a la clase DataContext que utilizará la base de datos especficada en el 
            // appsetting.Development.Json

            return services; // regresaremos todos los servicios configurados a la clase Startup.cs
        }
    }
}