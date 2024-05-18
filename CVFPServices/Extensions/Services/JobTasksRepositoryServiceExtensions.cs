using CVFPDataAccess.Repositories.JobTasks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class JobTasksRepositoryServiceExtensions
    {
        public static IServiceCollection AddJobTasksRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IJobTasksRepository, JobTasksRepository>();
            return services;
        }
    }
}
