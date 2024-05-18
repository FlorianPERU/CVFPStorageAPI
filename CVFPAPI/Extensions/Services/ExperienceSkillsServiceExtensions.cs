using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class ExperienceSkillsServiceExtensions
    {
        public static IServiceCollection AddExperienceSkillsServices(this IServiceCollection services)
        {
            services.AddScoped<IExperienceSkillsService, ExperienceSkillsService>();
            services.AddExperienceSkillsRepositoriesServices();
            return services;
        }
    }
}
