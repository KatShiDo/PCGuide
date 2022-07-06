using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class CPUController : Controller
    {
        private readonly IBaseService<CPU, CPUViewModel> _CPUService;

        public CPUController(IBaseService<CPU, CPUViewModel> CPUService)
        {
            _CPUService = CPUService;
        }

        public IActionResult Index()
        {
            var data = _CPUService.GetAll().Data
                .Select(x => (CPUViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _CPUService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
