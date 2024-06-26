using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CertificationsFormationsController : ControllerBase
    {

        private readonly ILogger<CertificationsFormationsController> _logger;
        private readonly ICertificationsFormationsService _certificationsFormationsService;
        public CertificationsFormationsController(ILogger<CertificationsFormationsController> logger, ICertificationsFormationsService certificationsFormationsService)
        {
            _logger = logger;
            _certificationsFormationsService = certificationsFormationsService;
        }

        [HttpGet(Name = "GetCertificationsFormations")]
        public async Task<CertificationsFormationsDTO> Get(int candidateId)
        {
            return await _certificationsFormationsService.GetCertificationsFormationsDTOByCandidateIdAsync(candidateId);
        }
    }
}
