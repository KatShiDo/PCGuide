using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.ViewModels
{
    public class CPUViewModel
    {
        public Guid Id { get; set; }

        public IFormFile Image { get; set; }

        public byte[]? ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Series { get; set; }

        public string Socket { get; set; }

        public string TechnicalProcess { get; set; }

        public int CoresCount { get; set; }

        public int ThreadsCount { get; set; }

        public double L1CacheCapacity { get; set; }

        public double L2CachCapacity { get; set; }

        public double L3CacheCapacity { get; set; }

        public bool HaveIntegratedGraphics { get; set; }

        public string IntegratedGraphics { get; set; }

        public double ClockSpeed { get; set; }

        public double? BoostClockSpeed { get; set; }

        public int TDP { get; set; }

        [Display(Name = "Оперативная память")]
        [Required(ErrorMessage = "Выберите тип")]
        public string RAMType { get; set; }

        public int RAMThreads { get; set; }
    }
}
