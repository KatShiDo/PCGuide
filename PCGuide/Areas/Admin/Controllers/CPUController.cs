using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CPUController : Controller
    {
        private readonly IBaseService<CPU, CPUViewModel> _CPUService;

        public CPUController(IBaseService<CPU, CPUViewModel> CPUService)
        {
            _CPUService = CPUService;
        }

        public IActionResult Index()
        {
            return View(_CPUService.GetAll().Data);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }

            var response = await _CPUService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CPUViewModel model)
        {
            ModelState.Remove("DateCreate");

            if (ModelState.IsValid)
            {
                using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                {
                    model.ImageData = binaryReader.ReadBytes((int)model.Image.Length);
                }

                model.DateCreate = DateTime.Now;

                if (model.Id == default)
                {
                    await _CPUService.CreateAsync(model);
                }
                else
                {
                    await _CPUService.EditAsync(model.Id, model);
                }

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _CPUService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
