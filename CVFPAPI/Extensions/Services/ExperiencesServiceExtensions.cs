using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class ExperiencesServiceExtensions
    {
        public static IServiceCollection AddExperiencesServices(this IServiceCollection services)
        {
            services.AddScoped<IExperiencesService, ExperiencesService>();
            services.AddExperiencesRepositoriesServices();
            return services;
        }
    }
}
