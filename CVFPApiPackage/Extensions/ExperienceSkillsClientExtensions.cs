using CVFPApiPackage.Client;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Extensions
{
    public static class ExperienceSkillsClientExtensions
    {
        internal static IServiceCollection AddExperienceSkillsClient(this IServiceCollection services, string baseAddress)
        {
            services.AddHttpClient<ExperienceSkillsClient>(client =>
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            return services;
        }
    }
}
