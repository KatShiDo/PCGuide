using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System.Linq;

namespace PCGuide.Controllers
{
    public class AboutController : Controller
    {
        private readonly IBaseService<TextField, TextFieldViewModel> _textFieldController;

        public AboutController(IBaseService<TextField, TextFieldViewModel> textFieldController)
        {
            _textFieldController = textFieldController;
        }

        public IActionResult Index()
        {
            return View(_textFieldController.GetAll().Data.FirstOrDefault(x => x.CodeWord == "PageCompany"));
        }
    }
}
