using CVFPDataAccess.Repositories.Candidates;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class CandidatesRepositoryServiceExtensions
    {
        public static IServiceCollection AddCandidatesRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<ICandidatesRepository, CandidatesRepository>();
            return services;
        }
    }
}
