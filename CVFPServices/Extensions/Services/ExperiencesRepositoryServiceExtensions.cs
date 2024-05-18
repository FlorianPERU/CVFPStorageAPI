using CVFPDataAccess.Repositories.Experiences;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class ExperiencesRepositoryServiceExtensions
    {
        public static IServiceCollection AddExperiencesRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IExperiencesRepository, ExperiencesRepository>();
            return services;
        }
    }
}
