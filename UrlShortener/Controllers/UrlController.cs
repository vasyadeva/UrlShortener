using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using UrlShortener.Interfaces;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly IUrlService urlService;

        public UrlController(IUrlService urlService)
        {
            this.urlService = urlService;
        }
        [HttpGet]
        public IActionResult GetUrls()
        {
            var response = urlService.GetAllUrls().Result;

            return Ok(response);
        }
        public class UrlDto
        {
            public string url { get; set; }
        }

        [HttpPost("AddUrl")]
        public IActionResult AddUrl([FromBody] UrlDto urlDto)
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var message = urlService.CreateShortUrl(urlDto.url, UserId);
            if (!string.IsNullOrEmpty(message.Result))
            {
                return BadRequest(new { error = message.Result });
            }
            return Ok();
        }

        [HttpDelete("DeleteUrl/{id}")]
        public IActionResult DeleteUrl(int id)
        {
            var response = urlService.DeleteUrlById(id).Result;

            if (!response)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("GetInfo/{id}")]
        public IActionResult GetInfo(int id)
        {
            var response = urlService.GetUrlById(id).Result;

            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
    }
}
