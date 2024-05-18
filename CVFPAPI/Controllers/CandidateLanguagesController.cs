using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateLanguagesController : ControllerBase
    {

        private readonly ILogger<CandidateLanguagesController> _logger;
        private readonly ICandidateLanguagesService _candidateLanguagesService;
        public CandidateLanguagesController(ILogger<CandidateLanguagesController> logger, ICandidateLanguagesService candidateLanguagesService)
        {
            _logger = logger;
            _candidateLanguagesService = candidateLanguagesService;
        }

        [HttpGet(Name = "GetCandidateLanguages")]
        public async Task<ICollection<CandidateLanguagesDTO>> Get(int userId)
        {
            return await _candidateLanguagesService.GetLanguagesDTOByUserIdAsync(userId);
        }
    }
}
