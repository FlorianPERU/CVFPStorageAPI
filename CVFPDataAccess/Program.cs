using CVFPDataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// Configuration de l'injection de dépendances
//var services = new ServiceCollection();
//services.AddDbContext<CVContext>(options => options.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;TrustServerCertificate=True;"));
//var serviceProvider = services.BuildServiceProvider();


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
////builder.Services.AddDbContext<CVContext>(options =>
////    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddDbContext<CVContext>(options =>
//    options.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;MultipleActiveResultSets=true"));
//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
