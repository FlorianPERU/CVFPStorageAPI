using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class CandidateServiceExtensions
    {
        public static IServiceCollection AddCandidateServices(this IServiceCollection services)
        {
            services.AddScoped<ICandidatesService, CandidatesService>();
            services.AddCandidatesRepositoriesServices();
            return services;
        }
    }
}
