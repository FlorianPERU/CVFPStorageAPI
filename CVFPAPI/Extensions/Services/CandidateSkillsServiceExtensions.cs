using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class CandidateSkillsServiceExtensions
    {
        public static IServiceCollection AddCandidateSkillsServices(this IServiceCollection services)
        {
            services.AddScoped<ICandidateSkillsService, CandidateSkillsService>();
            services.AddCandidateSkillsRepositoriesServices();
            return services;
        }
    }
}
