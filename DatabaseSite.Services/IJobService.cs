using DatabaseSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseSite.Services
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetJobs();
        Task<Job?> GetJob(int id);
        Task<Job> AddJob(Job job);
    }
}
