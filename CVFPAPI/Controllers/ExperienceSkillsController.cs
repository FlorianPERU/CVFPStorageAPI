using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceSkillsController : ControllerBase
    {

        private readonly ILogger<ExperienceSkillsController> _logger;
        private readonly IExperienceSkillsService _experienceSkillsService;
        public ExperienceSkillsController(ILogger<ExperienceSkillsController> logger, IExperienceSkillsService experienceSkillsService)
        {
            _logger = logger;
            _experienceSkillsService = experienceSkillsService;
        }

        [HttpGet(Name = "GetExperienceSkills")]
        public async Task<ICollection<ExperienceSkillDTO>> Get(int userId)
        {
            return await _experienceSkillsService.GetExperienceSkillsDTOByUserIdCandidateAsync(userId);
        }
    }
}
