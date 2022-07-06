using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class GPUController : Controller
    {
        private readonly IBaseService<GPU, GPUViewModel> _GPUService;

        public GPUController(IBaseService<GPU, GPUViewModel> GPUService)
        {
            _GPUService = GPUService;
        }

        public IActionResult Index()
        {
            var data = _GPUService.GetAll().Data
                .Select(x => (GPUViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _GPUService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
