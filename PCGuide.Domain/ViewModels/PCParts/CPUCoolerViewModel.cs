using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class CPUCoolerViewModel
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

        [Display(Name = "TDP")]
        [Required(ErrorMessage = "Введите TDP")]
        public ushort TDP { get; set; }

        [Display(Name = "Высота")]
        [Required(ErrorMessage = "Введите высоту")]
        public ushort Height { get; set; }
    }
}
