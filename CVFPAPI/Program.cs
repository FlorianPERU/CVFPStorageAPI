//using CVFPDataAccess.Data;

using CVFPDataAccess.Data;
using CVFPDataAccess.Repositories.Candidates;
using CVFPDataAccess.Repositories.Certifications;
using CVFPDataAccess.Repositories.Formations;
using CVFPDataAccess.Repositories.HardSkills;
using CVFPDataAccess.Repositories.Hobbies;
using CVFPDataAccess.Repositories.Languages;
using CVFPDataAccess.Repositories.SoftSkills;
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
#region Injection

#region Candidates
builder.Services.AddScoped<ICandidatesService, CandidatesService>();
builder.Services.AddScoped<ICandidatesRepository, CandidatesRepository>();
#endregion
#region Certifications Formations
builder.Services.AddScoped<ICertificationsFormationsService, CertificationsFormationsService>();
builder.Services.AddScoped<ICertificationsRepository, CertificationsRepository>();
builder.Services.AddScoped<IFormationsRepository, FormationsRepository>();
#endregion

#region Candidate Skills
builder.Services.AddScoped<ICandidateSkillsService, CandidateSkillsService>();
builder.Services.AddScoped<ISoftSkillsRepository, SoftSkillsRepository>();
builder.Services.AddScoped<IHardSkillsRepository, HardSkillsRepository>();
#endregion

#region Candidate Hobbies
builder.Services.AddScoped<ICandidateHobbiesService, CandidateHobbiesService>();
builder.Services.AddScoped<IHobbiesRepository, HobbiesRepository>();
#endregion

#region Candidate Languages
builder.Services.AddScoped<ICandidateLanguagesService, CandidateLanguagesService>();
builder.Services.AddScoped<ILanguagesRepository, LanguagesRepository>();
#endregion

builder.Configuration.AddJsonFile("appsettings.json",
        optional: true,
        reloadOnChange: true);
builder.Services.AddDbContext<CVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
#endregion

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
