using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class CandidateHobbiesServiceExtensions
    {
        public static IServiceCollection AddCandidateHobbiesServices(this IServiceCollection services)
        {
            services.AddScoped<ICandidateHobbiesService, CandidateHobbiesService>();
            services.AddCandidateHobbiesRepositoriesServices();
            return services;
        }
    }
}
