using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System.Threading.Tasks;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly ITextFieldService _textFieldService;

        public TextFieldsController(ITextFieldService textFieldService)
        {
            _textFieldService = textFieldService;
        }

        public async Task<IActionResult> Edit(string codeWord)
        {
            var entity = await _textFieldService.GetTextFieldByCodeWordAsync(codeWord);
            return View(entity.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TextFieldViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _textFieldService.EditTextFieldAsync(model.Id, model);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
