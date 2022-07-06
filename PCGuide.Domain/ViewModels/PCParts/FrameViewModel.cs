using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class FrameViewModel : PCPartViewModel
    {
        [Display(Name = "Высота")]
        [Required(ErrorMessage = "Введите высоту")]
        public ushort Height { get; set; }

        [Display(Name = "Ширина")]
        [Required(ErrorMessage = "Введите ширину")]
        public ushort Width { get; set; }

        [Display(Name = "Длина")]
        [Required(ErrorMessage = "Введите длину")]
        public ushort Lenght { get; set; }

        [Display(Name = "Форм-фактор материнской платы")]
        public string MotherboardType { get; set; }

        public static explicit operator FrameViewModel(Frame frame)
        {
            return new FrameViewModel
            {
                Id = frame.Id,
                ImageData = frame.ImageData,
                DateCreate = frame.DateCreate,
                Name = frame.Name,
                Company = frame.Company.ToString(),
                Height = frame.Height,
                Width = frame.Width,
                Lenght = frame.Lenght,
                MotherboardType = frame.MotherboardType.ToString()
            };
        }

        public static explicit operator Frame(FrameViewModel frameViewModel)
        {
            var frame = new Frame
            {
                Id = frameViewModel.Id,
                ImageData = frameViewModel.ImageData,
                DateCreate = frameViewModel.DateCreate,
                Name = frameViewModel.Name,
                Height = frameViewModel.Height,
                Width = frameViewModel.Width,
                Lenght = frameViewModel.Lenght
            };

            System.Enum.TryParse(frameViewModel.Company, out Company company);
            frame.Company = company;

            System.Enum.TryParse(frameViewModel.MotherboardType, out MotherboardType motherboardType);
            frame.MotherboardType = motherboardType;

            return frame;
        }

        public void CopyToModel(ref Frame model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;
            model.Height = Height;
            model.Width = Width;
            model.Lenght = Lenght;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;
        }
    }
}
