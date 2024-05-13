//using CVFPDataAccess.Data;

using CVFPDataAccess.Data;
using CVFPDataAccess.Repositories.Candidates;
using CVFPDataAccess.Repositories.Certifications;
using CVFPDataAccess.Repositories.Formations;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICandidatesService, CandidatesService>();
builder.Services.AddScoped<ICandidatesRepository, CandidatesRepository>();
builder.Services.AddScoped<ICertificationsFormationsService, CertificationsFormationsService>();
builder.Services.AddScoped<ICertificationsRepository, CertificationsRepository>();
builder.Services.AddScoped<IFormationsRepository, FormationsRepository>();

builder.Configuration.AddJsonFile("appsettings.json",
        optional: true,
        reloadOnChange: true);
builder.Services.AddDbContext<CVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddDbContext<CVContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
