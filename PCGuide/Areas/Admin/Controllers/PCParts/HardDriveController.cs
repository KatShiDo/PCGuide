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
    public class HardDriveController : Controller
    {
        private readonly IBaseService<HardDrive, HardDriveViewModel> _hardDriveService;

        public HardDriveController(IBaseService<HardDrive, HardDriveViewModel> hardDriveService)
        {
            _hardDriveService = hardDriveService;
        }

        public IActionResult Index()
        {
            return View(_hardDriveService.GetAll().Data.Select(x => (HardDriveViewModel)x));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }

            var response = await _hardDriveService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HardDriveViewModel model)
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
                    await _hardDriveService.CreateAsync(model);
                }
                else
                {
                    await _hardDriveService.EditAsync(model);
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _hardDriveService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
