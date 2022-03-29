using Microsoft.AspNetCore.Mvc;
using threatening.dragon.Domain.Catalog;

namespace threatening.dragon.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };

            return Ok(items);
        }
    }
    
}