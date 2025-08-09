using DatabaseSite.Data;
using DatabaseSite.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseSite.Services
{
    public class JobService : IJobService
    {
        private readonly ApplicationDbContext _context;

        public JobService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetJob(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }

        public async Task<Job> AddJob(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }
    }
}
