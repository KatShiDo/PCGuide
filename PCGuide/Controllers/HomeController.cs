using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System.Linq;

namespace PCGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseService<TextField, TextFieldViewModel> _textFieldService;

        public HomeController(IBaseService<TextField, TextFieldViewModel> textFieldService)
        {
            _textFieldService = textFieldService;
        }

        public IActionResult Index()
        {
            return View(_textFieldService.GetAll().Data.FirstOrDefault(x => x.CodeWord == "PageIndex"));
        }
    }
}
