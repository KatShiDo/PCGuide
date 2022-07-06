using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service;
using PCGuide.Service.Interfaces;
using System.Linq;

namespace PCGuide.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IBaseService<TextField, TextFieldViewModel> _textFieldService;

        public CatalogController(IBaseService<TextField, TextFieldViewModel> textFieldService)
        {
            _textFieldService = textFieldService;
        }

        public IActionResult Index()
        {
            return View((TextFieldViewModel)_textFieldService.GetAll().Data.FirstOrDefault(x => x.CodeWord == "PageCatalog"));
        }
    }
}
