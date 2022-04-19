using Microsoft.AspNetCore.Mvc;
using PCGuide.Service.Interfaces;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
