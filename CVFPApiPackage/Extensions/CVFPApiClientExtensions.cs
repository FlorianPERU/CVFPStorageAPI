using CVFPApiPackage.Client;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Extensions
{
    public static class CVFPApiClientExtensions
    {
        public static IServiceCollection AddCVFPApiService(this IServiceCollection services, string baseAddress)
        {

            services.AddCandidateClient(baseAddress);
            services.AddJobTasksClient(baseAddress);
            services.AddCandidateHobbiesClient(baseAddress);
            services.AddCandidateLanguagesClient(baseAddress);
            services.AddCandidateSkillsClient(baseAddress);
            services.AddCertificationsFormationsClient(baseAddress);
            services.AddExperiencesClient(baseAddress);
            services.AddExperienceSkillsClient(baseAddress);
            services.AddScoped<CVFPApiClient>();

            return services;
        }
    }
}
