using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class TextFieldViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (заголовок)")]
        [Required(ErrorMessage = "Введите название")]
        public string Title { get; set; }

        [Display(Name = "Содержание страницы")]
        public string Text { get; set; }

        [Display(Name = "SEO метатег Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }
    }
}
