using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class HardDriveController : Controller
    {
        private readonly IBaseService<HardDrive, HardDriveViewModel> _hardDriveService;

        public HardDriveController(IBaseService<HardDrive, HardDriveViewModel> hardDriveService)
        {
            _hardDriveService = hardDriveService;
        }

        public IActionResult Index()
        {
            var data = _hardDriveService.GetAll().Data
                .Select(x => (HardDriveViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _hardDriveService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
