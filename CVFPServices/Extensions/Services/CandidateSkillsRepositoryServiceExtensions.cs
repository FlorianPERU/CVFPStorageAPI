using CVFPDataAccess.Repositories.HardSkills;
using CVFPDataAccess.Repositories.SoftSkills;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class CandidateSkillsRepositoryServiceExtensions
    {
        public static IServiceCollection AddCandidateSkillsRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<ISoftSkillsRepository, SoftSkillsRepository>();
            services.AddScoped<IHardSkillsRepository, HardSkillsRepository>();
            return services;
        }
    }
}
