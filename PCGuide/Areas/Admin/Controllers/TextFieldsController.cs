using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly IBaseService<TextField, TextFieldViewModel> _textFieldService;

        public TextFieldsController(IBaseService<TextField, TextFieldViewModel> textFieldService)
        {
            _textFieldService = textFieldService;
        }

        public IActionResult Index()
        {
            return View(_textFieldService.GetAll().Data.Select(x => (TextFieldViewModel)x));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _textFieldService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TextFieldViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _textFieldService.EditAsync(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
