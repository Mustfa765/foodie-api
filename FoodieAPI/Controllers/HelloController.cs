using Microsoft.AspNetCore.Mvc;

namespace FoodieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("✅ Foodie API is working!");
        }
    }
}
