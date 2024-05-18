using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class CertificationsFormationsServiceExtensions
    {
        public static IServiceCollection AddCertificationsFormationsServices(this IServiceCollection services)
        {
            services.AddScoped<ICertificationsFormationsService, CertificationsFormationsService>();
            services.AddCertificationsFormationsRepositoriesServices();
            return services;
        }
    }
}
