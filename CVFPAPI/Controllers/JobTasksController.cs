using CVFPServices.DTOs;
using CVFPServices.Services;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CVFPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobTasksController : ControllerBase
    {

        private readonly ILogger<JobTasksController> _logger;
        private readonly IJobTasksService _jobTasksService;
        public JobTasksController(ILogger<JobTasksController> logger, IJobTasksService jobTasksService)
        {
            _logger = logger;
            _jobTasksService = jobTasksService;
        }

        [HttpGet(Name = "GetJobTasks")]
        public async Task<ICollection<JobTaskDTO>> Get(int candidateId)
        {
            return await _jobTasksService.GetJobTasksDTOByCandidateIdAsync(candidateId);
        }
    }
}
