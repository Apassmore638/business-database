using DatabaseSite.Data;
using DatabaseSite.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseSite.Services
{
    public class TriageItemService : ITriageItemService
    {
        private readonly ApplicationDbContext _context;

        public TriageItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TriageItem>> GetTriageItemsAsync()
        {
            return await _context.TriageItems.ToListAsync();
        }

        public async Task AddTriageItemAsync(TriageItem triageItem)
        {
            _context.TriageItems.Add(triageItem);
            await _context.SaveChangesAsync();
        }
    }
}
