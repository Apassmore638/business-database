using DatabaseSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseSite.Services
{
    public interface ITriageItemService
    {
        Task<List<TriageItem>> GetTriageItemsAsync();
        Task AddTriageItemAsync(TriageItem triageItem);
    }
}
