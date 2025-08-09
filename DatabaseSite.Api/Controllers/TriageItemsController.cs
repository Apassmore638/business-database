using DatabaseSite.Models;
using DatabaseSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriageItemsController : ControllerBase
    {
        private readonly ITriageItemService _triageItemService;

        public TriageItemsController(ITriageItemService triageItemService)
        {
            _triageItemService = triageItemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TriageItem>>> GetTriageItems()
        {
            var triageItems = await _triageItemService.GetTriageItemsAsync();
            return Ok(triageItems);
        }

        [HttpPost]
        public async Task<ActionResult<TriageItem>> AddTriageItem(TriageItem triageItem)
        {
            await _triageItemService.AddTriageItemAsync(triageItem);
            return CreatedAtAction(nameof(GetTriageItems), new { id = triageItem.Id }, triageItem);
        }
    }
}
