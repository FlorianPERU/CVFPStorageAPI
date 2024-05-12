using CVFPServices.DTOs;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetFirstCandidateController : ControllerBase
    {

        private readonly ILogger<GetFirstCandidateController> _logger;
        private readonly ICandidatesService _candidatesService;
        public GetFirstCandidateController(ILogger<GetFirstCandidateController> logger, ICandidatesService candidatesService)
        {
            _logger = logger;
            _candidatesService = candidatesService;
        }

        [HttpGet(Name = "GetFirstCandidate")]
        public CandidateDTO Get()
        {
            return _candidatesService.GetFirstCandidateDTO();
        }
    }
}
