using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Response;
using PCGuide.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace PCGuide.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public IActionResult GetNews()
        {
            var response = _newsService.GetNews();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error", $"{response.Description}");
        }

        [HttpGet]
        public async Task<IActionResult> GetNewsByTag(string tag)
        {
            var response = await _newsService.GetNewsByTagAsync(tag);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View("GetNews", response.Data);
            }

            return RedirectToAction("Error", $"{response.Description}");
        }
    }
}
