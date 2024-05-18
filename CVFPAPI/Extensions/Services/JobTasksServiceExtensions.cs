using CVFPServices.Extensions.Services;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;

namespace CVFPAPI.Extensions.Services
{
    public static class JobTasksServiceExtensions
    {
        public static IServiceCollection AddJobTasksServices(this IServiceCollection services)
        {
            services.AddScoped<IJobTasksService, JobTasksService>();
            services.AddJobTasksRepositoriesServices();
            return services;
        }
    }
}
