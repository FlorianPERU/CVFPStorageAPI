using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class CandidateLanguagesServiceExtensions
    {
        public static IServiceCollection AddCandidateLanguagesServices(this IServiceCollection services)
        {
            services.AddScoped<ICandidateLanguagesService, CandidateLanguagesService>();
            services.AddCandidateLanguagesRepositoriesServices();
            return services;
        }
    }
}
