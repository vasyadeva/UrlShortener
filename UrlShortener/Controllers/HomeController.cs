using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UrlShortener.Interfaces;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDescriptionService descriptionService;

        public HomeController(ILogger<HomeController> logger, IDescriptionService descriptionService)
        {
            _logger = logger;
            this.descriptionService = descriptionService;
        }

        public IActionResult Index()
        {
            return View();
        }

    
        public IActionResult About()
        {
            ViewData["Description"] = descriptionService.GetDescription().Result;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> About(string description)
        {
            if (ModelState.IsValid)
            {
                await descriptionService.ModifyDescription(description);
                ViewData["Description"] = description;
                return RedirectToAction("About");
            }
            ViewData["Description"] = await descriptionService.GetDescription();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
