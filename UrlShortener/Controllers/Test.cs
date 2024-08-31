using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var response = new
            {
                Message = "Привіт, Фоксік!",
                Date = DateTime.Now
            };

            return Ok(response);
        }
    }
}
