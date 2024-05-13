using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateSkillsController : ControllerBase
    {

        private readonly ILogger<CandidateSkillsController> _logger;
        private readonly ICandidateSkillsService _candidateSkillsService;
        public CandidateSkillsController(ILogger<CandidateSkillsController> logger, ICandidateSkillsService candidateSkillsService)
        {
            _logger = logger;
            _candidateSkillsService = candidateSkillsService;
        }

        [HttpGet(Name = "GetCandidateSkills")]
        public CandidateSkillsDTO Get(int userId)
        {
            return _candidateSkillsService.GetCandidateSkillsDTOByUserId(userId);
        }
    }
}
