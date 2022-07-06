using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PCGuide.Domain.ViewModels
{
    public class NewsViewModel : IIdentifiable
    {
        public Guid Id { get; set; }

        [Display(Name = "Картинка")]
        //[Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Image { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Введите заголовок")]
        [MinLength(5, ErrorMessage = "Минимальная длина - 5 символов")]
        public string Title { get; set; }

        [Display(Name = "Описание новости")]
        public string Description { get; set; }

        public List<string> Tags { get; set; }

        [Display(Name = "Теги")]
        public string TagsString { get; set; }

        public static explicit operator NewsViewModel(News news)
        {
            return new NewsViewModel
            {
                Id = news.Id,
                ImageData = news.ImageData,
                DateCreate = news.DateCreate,
                Title = news.Title,
                Description = news.Description,
                Tags = news.TagsString.Split(" ").ToList(),
                TagsString = news.TagsString
            };
        }

        public static explicit operator News(NewsViewModel newsViewModel)
        {
            return new News
            {
                Id = newsViewModel.Id,
                ImageData = newsViewModel.ImageData,
                DateCreate = newsViewModel.DateCreate,
                Title = newsViewModel.Title,
                Description = newsViewModel.Description,
                TagsString = newsViewModel.TagsString
            };
        }

        public void CopyToModel(ref News model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Title = Title;
            model.Description = Description;
            model.TagsString = TagsString;
        }
    }
}
