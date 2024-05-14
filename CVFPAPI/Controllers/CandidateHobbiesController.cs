using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateHobbiesController : ControllerBase
    {

        private readonly ILogger<CandidateHobbiesController> _logger;
        private readonly ICandidateHobbiesService _candidateHobbiesService;
        public CandidateHobbiesController(ILogger<CandidateHobbiesController> logger, ICandidateHobbiesService candidateHobbiesService)
        {
            _logger = logger;
            _candidateHobbiesService = candidateHobbiesService;
        }

        [HttpGet(Name = "GetCandidateHobbies")]
        public ICollection<CandidateHobbiesDTO> Get(int userId)
        {
            return _candidateHobbiesService.GetHobbiesDTOByUserId(userId);
        }
    }
}
