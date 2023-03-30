using Microsoft.AspNetCore.Mvc;
using Purple.Vipers.Domain.Catalog;

namespace Purple.Vipers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio state shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio state shorts.", "Nike", 44.99m)
            };
            
            return Ok(items);
        }
    }
}
