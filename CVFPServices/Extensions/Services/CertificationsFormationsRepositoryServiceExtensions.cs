using CVFPDataAccess.Repositories.Certifications;
using CVFPDataAccess.Repositories.Formations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions.Services
{
    public static class CertificationsFormationsRepositoryServiceExtensions
    {
        public static IServiceCollection AddCertificationsFormationsRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<ICertificationsRepository, CertificationsRepository>();
            services.AddScoped<IFormationsRepository, FormationsRepository>();
            return services;
        }
    }
}
