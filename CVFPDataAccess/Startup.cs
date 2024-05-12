using CVFPDataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

//namespace CVFPDataAccess
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddDbContext<CVContext>(options =>
//       options.UseSqlServer(Configuration.GetConnectionString("Server=localhost;Database=CVFP;Trusted_Connection=True;MultipleActiveResultSets=true")));

//            // Injection du contexte de base de données dans votre projet DataAccess
//            services.AddScoped<CVContext>(provider =>
//            {
//                var options = provider.GetRequiredService<DbContextOptions<CVContext>>();
//                return new CVContext(options);
//            });

//            // Autres configurations de services...
//        }
//    }
//}