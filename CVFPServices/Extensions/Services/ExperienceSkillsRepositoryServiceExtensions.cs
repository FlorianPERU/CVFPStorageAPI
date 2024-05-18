using CVFPDataAccess.Repositories.ExperienceSkills;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class ExperienceSkillsRepositoryServiceExtensions
    {
        public static IServiceCollection AddExperienceSkillsRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IExperienceSkillsRepository, ExperienceSkillsRepository>();
            return services;
        }
    }
}
