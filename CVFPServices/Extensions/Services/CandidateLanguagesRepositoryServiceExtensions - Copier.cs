using CVFPDataAccess.Repositories.Languages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class CandidateLanguagesRepositoryServiceExtensions
    {
        public static IServiceCollection AddCandidateLanguagesRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<ILanguagesRepository, LanguagesRepository>();
            return services;
        }
    }
}
