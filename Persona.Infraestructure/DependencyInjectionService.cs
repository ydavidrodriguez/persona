using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persona.Application;
using Persona.Domain.Services.Interfaces.Persona;
using Persona.Infraestructure.DataBase;
using Persona.Infraestructure.Repositories.Persona;

namespace Persona.Infraestructure
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DataBaseService>(options =>
            options.UseSqlServer(configuration["sqlconnectionstrings"]));

            services.AddScoped<IDataBaseService, DataBaseService>();
            services.AddScoped<IPersonaRepository, PersonaRepository>();
            //GetToken
            //services.AddTransient<IGettokenJwt, GetTokenJwtService.GetTokenJwtService>();

            return services;
        }



    }
}
