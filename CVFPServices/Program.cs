using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using CVFPDataAccess.Repositories;


var services = new ServiceCollection();
services.AddSingleton<ICandidatesRepository, CandidatesRepository>();

        //ConfigureServices(services);

//var serviceProvider = services.BuildServiceProvider();

//using (var scope = serviceProvider.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<CVContext>();

//    // Vous pouvez maintenant utiliser votre dbContext ici
//}


//static void ConfigureServices(IServiceCollection services)
//{
//    //services.AddDbContext<CVContext>(options =>
//    //    options.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;TrustServerCertificate=True;")
//    //);
//}


//var services = new ServiceCollection();
//services.AddDbContext<CVContext>(options =>
//options.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;TrustServerCertificate=True;")
//);
//var serviceProvider = services.BuildServiceProvider();

//var dbContext = serviceProvider.GetRequiredService<CVContext>();

////IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MyCookingMaster.API/appsettings.json").Build();
////var builder = new DbContextOptionsBuilder<CVContext>();
//////var connectionString = configuration.GetConnectionString("DatabaseConnection");
////builder.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;TrustServerCertificate=True;");
//////var builder = WebApplication.CreateBuilder(args);
////CVContext ok = new CVContext(builder.Options);
//builder.Services.AddDbContext<CVContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



//var app = builder.Build();


//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

