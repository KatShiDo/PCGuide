using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.ViewModels
{
    public class PowerUnitViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Image { get; set; }

        public byte[]? ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Мощность")]
        public int Power { get; set; }
    }
}
