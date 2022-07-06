using PCGuide.Domain.Entities;
using PCGuide.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class TextFieldViewModel : IIdentifiable
    {
        public Guid Id { get; set; }

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

        public static explicit operator TextFieldViewModel(TextField textField)
        {
            return new TextFieldViewModel
            {
                Id = textField.Id,
                CodeWord = textField.CodeWord,
                Title = textField.Title,
                Text = textField.Text,
                MetaTitle = textField.MetaTitle,
                MetaDescription = textField.MetaDescription,
                MetaKeywords = textField.MetaKeywords
            };
        }

        public static explicit operator TextField(TextFieldViewModel textFieldViewModel)
        {
            return new TextField
            {
                Id = textFieldViewModel.Id,
                CodeWord = textFieldViewModel.CodeWord,
                Title = textFieldViewModel.Title,
                Text = textFieldViewModel.Text,
                MetaTitle = textFieldViewModel.MetaTitle,
                MetaDescription = textFieldViewModel.MetaDescription,
                MetaKeywords = textFieldViewModel.MetaKeywords
            };
        }

        public void CopyToModel(ref TextField model)
        {
            model.Title = Title;
            model.Text = Text;
            model.MetaTitle = MetaTitle;
            model.MetaDescription = MetaDescription;
            model.MetaKeywords = MetaKeywords;
        }
    }
}
