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
    public class RAMController : Controller
    {
        private readonly IBaseService<RAM, RAMViewModel> _RAMService;

        public RAMController(IBaseService<RAM, RAMViewModel> RAMService)
        {
            _RAMService = RAMService;
        }

        public IActionResult Index()
        {
            return View(_RAMService.GetAll().Data.Select(x => (RAMViewModel)x));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }

            var response = await _RAMService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RAMViewModel model)
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
                    await _RAMService.CreateAsync(model);
                }
                else
                {
                    await _RAMService.EditAsync(model);
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _RAMService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}