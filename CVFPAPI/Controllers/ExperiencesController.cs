using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperiencesController : ControllerBase
    {

        private readonly ILogger<ExperiencesController> _logger;
        private readonly IExperiencesService _experiencesService;
        public ExperiencesController(ILogger<ExperiencesController> logger, IExperiencesService experiencesService)
        {
            _logger = logger;
            _experiencesService = experiencesService;
        }

        [HttpGet(Name = "GetExperiences")]
        public ICollection<ExperienceDTO> Get(int userId)
        {
            return _experiencesService.GetExperiencesDTOByUserIdCandidate(userId);
        }
    }
}
