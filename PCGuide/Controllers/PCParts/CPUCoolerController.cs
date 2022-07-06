using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class CPUCoolerController : Controller
    {
        private readonly IBaseService<CPUCooler, CPUCoolerViewModel> _CPUCoolerService;

        public CPUCoolerController(IBaseService<CPUCooler, CPUCoolerViewModel> CPUCoolerService)
        {
            _CPUCoolerService = CPUCoolerService;
        }

        public IActionResult Index()
        {
            var data = _CPUCoolerService.GetAll().Data
                .Select(x => (CPUCoolerViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _CPUCoolerService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
