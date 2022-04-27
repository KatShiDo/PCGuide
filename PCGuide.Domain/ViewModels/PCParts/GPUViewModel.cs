using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class GPUViewModel
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

        [Display(Name = "Размер видеопамяти")]
        [Required(ErrorMessage = "Введите размер видеопамяти")]
        public ushort MemoryCapacity { get; set; }

        [Display(Name = "Тип видеопамяти")]
        public string MemoryType { get; set; }

        [Display(Name = "Техпроцесс")]
        public string TechnicalProcess { get; set; }

        [Display(Name = "Частота ядра")]
        [Required(ErrorMessage = "Введите частоту")]
        public float ClockSpeed { get; set; }

        [Display(Name = "TDP")]
        [Required(ErrorMessage = "Введите TDP")]
        public ushort TDP { get; set; }

        [Display(Name = "Длина")]
        [Required(ErrorMessage = "Введите длину")]
        public ushort Length { get; set; }
    }
}
