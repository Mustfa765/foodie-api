using Microsoft.AspNetCore.Mvc;

namespace FoodieAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("📡 Welcome to Foodie API! ✅");
        }
    }
}
