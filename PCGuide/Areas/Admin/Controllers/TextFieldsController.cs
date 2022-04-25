using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
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
            return View(_textFieldService.GetAll().Data);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var entity = await _textFieldService.GetByIdAsync(id);
            return View(entity.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TextFieldViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _textFieldService.EditAsync(model.Id, model);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
