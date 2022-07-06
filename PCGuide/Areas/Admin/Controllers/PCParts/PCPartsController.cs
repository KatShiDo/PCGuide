using Microsoft.AspNetCore.Mvc;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PCPartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
