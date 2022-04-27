using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class CPUViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Картинка")]
        //[Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Image { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название")]
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
        [Required(ErrorMessage = "Введите количество ядер")]
        public ushort CoresCount { get; set; }

        [Display(Name = "Количество потоков")]
        [Required(ErrorMessage = "Введите количество потоков")]
        public ushort ThreadsCount { get; set; }

        [Display(Name = "Кэш")]
        [Required(ErrorMessage = "Введите кэш")]
        public ushort CacheCapacity { get; set; }

        [Display(Name = "Наличие интегрированного видеоядра")]
        public bool HaveIntegratedGraphics { get; set; }

        [Display(Name = "Модель интегрированной графики")]
        public string IntegratedGraphics { get; set; }

        [Display(Name = "Частота ядра")]
        [Required(ErrorMessage = "Введите частоту")]
        public float ClockSpeed { get; set; }

        [Display(Name = "Частота в бусте")]
        public float BoostClockSpeed { get; set; }

        [Display(Name = "TDP")]
        [Required(ErrorMessage = "Введите TDP")]
        public ushort TDP { get; set; }

        [Display(Name = "Оперативная память")]
        public string RAMType { get; set; }

        [Display(Name = "Количество потоков оперативной памяти")]
        [Required(ErrorMessage = "Введите количество потоков оперативной памяти")]
        public ushort RAMThreads { get; set; }
    }
}
