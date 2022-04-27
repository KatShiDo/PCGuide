using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service;
using PCGuide.Service.Interfaces;
using System.Linq;

namespace PCGuide.Controllers
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
            return View(_CPUService.GetAll().Data.Select(x => x.ToViewModel()));
        }
    }
}
