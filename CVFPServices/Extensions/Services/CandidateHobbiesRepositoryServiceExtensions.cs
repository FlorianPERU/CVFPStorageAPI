using CVFPDataAccess.Repositories.Hobbies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class CandidateHobbiesRepositoryServiceExtensions
    {
        public static IServiceCollection AddCandidateHobbiesRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IHobbiesRepository, HobbiesRepository>();
            return services;
        }
    }
}
