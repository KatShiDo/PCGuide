using Microsoft.AspNetCore.Mvc;
using PCGuide.Service.Interfaces;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly INewsService _newsService;

        public HomeController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            return View(_newsService.GetNews());
        }
    }
}
