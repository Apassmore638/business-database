using DatabaseSite.Models;
using DatabaseSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> GetJobs()
        {
            var jobs = await _jobService.GetJobs();
            return Ok(jobs);
        }

        [HttpPost]
        public async Task<ActionResult<Job>> PostJob(Job job)
        {
            var newJob = await _jobService.AddJob(job);
            return CreatedAtAction(nameof(GetJob), new { id = newJob.JobId }, newJob);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJob(int id)
        {
            var job = await _jobService.GetJob(id);
            if (job == null)
            {
                return NotFound();
            }
            return Ok(job);
        }
    }
}
