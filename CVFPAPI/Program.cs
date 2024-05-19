//using CVFPDataAccess.Data;

using CVFPAPI.Extensions.Services;
using CVFPDataAccess.Data;
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
builder.Services.AddCandidateServices();
#endregion
#region Certifications Formations
builder.Services.AddCertificationsFormationsServices();
#endregion

#region Candidate Skills
builder.Services.AddCandidateSkillsServices();
#endregion

#region Candidate Hobbies
builder.Services.AddCandidateHobbiesServices();
#endregion

#region Candidate Languages
builder.Services.AddCandidateLanguagesServices();
#endregion

#region Candidate Experiences
builder.Services.AddExperiencesServices();
#endregion

#region JobTasks
builder.Services.AddJobTasksServices();
#endregion

#region ExperienceSkills
builder.Services.AddExperienceSkillsServices();
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
