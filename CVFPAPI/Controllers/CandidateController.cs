using CVFPServices.DTOs;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {

        private readonly ILogger<CandidateController> _logger;
        private readonly ICandidatesService _candidatesService;
        public CandidateController(ILogger<CandidateController> logger, ICandidatesService candidatesService)
        {
            _logger = logger;
            _candidatesService = candidatesService;
        }

        [HttpGet(Name = "GetFirstCandidate")]
        public async Task<CandidateDTO> Get()
        {
            return await _candidatesService.GetFirstCandidateDTOAsync();
        }
    }
}
