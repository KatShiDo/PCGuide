using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MotherboardController : Controller
    {
        private readonly IBaseService<Motherboard, MotherboardViewModel> _motherboardService;

        public MotherboardController(IBaseService<Motherboard, MotherboardViewModel> motherboardService)
        {
            _motherboardService = motherboardService;
        }

        public IActionResult Index()
        {
            return View(_motherboardService.GetAll().Data.Select(x => (MotherboardViewModel)x));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }

            var response = await _motherboardService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MotherboardViewModel model)
        {
            ModelState.Remove("DateCreate");

            if (ModelState.IsValid)
            {
                if (model.Image != null)
                {
                    using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                    {
                        model.ImageData = binaryReader.ReadBytes((int)model.Image.Length);
                    }
                }

                model.DateCreate = DateTime.Now;

                if (model.Id == default)
                {
                    await _motherboardService.CreateAsync(model);
                }
                else
                {
                    await _motherboardService.EditAsync(model);
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _motherboardService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
