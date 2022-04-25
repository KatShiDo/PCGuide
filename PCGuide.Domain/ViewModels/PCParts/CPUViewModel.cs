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

        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Image { get; set; }

        public byte[]? ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Производитель")]
        public string Company { get; set; }

        [Display(Name = "Поколение")]
        public string Series { get; set; }

        [Display(Name = "Сокет")]
        public string Socket { get; set; }

        [Display(Name = "Техпроцесс")]
        public string TechnicalProcess { get; set; }

        [Display(Name = "Количество ядер")]
        public int CoresCount { get; set; }

        [Display(Name = "Количество потоков")]
        public int ThreadsCount { get; set; }

        [Display(Name = "Кэш L1")]
        public double L1CacheCapacity { get; set; }

        [Display(Name = "Кеш L2")]
        public double L2CachCapacity { get; set; }

        [Display(Name = "Кеш L3")]
        public double L3CacheCapacity { get; set; }

        [Display(Name = "Наличие интегрированного видеоядра")]
        public bool HaveIntegratedGraphics { get; set; }

        [Display(Name = "Модель интегрированной графики")]
        public string IntegratedGraphics { get; set; }

        [Display(Name = "Частота ядра")]
        public double ClockSpeed { get; set; }

        [Display(Name = "Частота в бусте")]
        public double? BoostClockSpeed { get; set; }

        [Display(Name = "TDP")]
        public int TDP { get; set; }

        [Display(Name = "Оперативная память")]
        [Required(ErrorMessage = "Выберите тип")]
        public string RAMType { get; set; }

        [Display(Name = "Количество потоков оперативной памяти")]
        public int RAMThreads { get; set; }
    }
}
