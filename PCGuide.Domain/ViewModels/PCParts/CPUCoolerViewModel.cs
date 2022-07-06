using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class CPUCoolerViewModel : PCPartViewModel
    {
        [Display(Name = "TDP")]
        [Required(ErrorMessage = "Введите TDP")]
        public ushort TDP { get; set; }

        [Display(Name = "Высота")]
        [Required(ErrorMessage = "Введите высоту")]
        public ushort Height { get; set; }

        public static explicit operator CPUCoolerViewModel(CPUCooler CPUCooler)
        {
            return new CPUCoolerViewModel
            {
                Id = CPUCooler.Id,
                ImageData = CPUCooler.ImageData,
                DateCreate = CPUCooler.DateCreate,
                Name = CPUCooler.Name,
                Company = CPUCooler.Company.ToString(),
                TDP = CPUCooler.TDP,
                Height = CPUCooler.Height
            };
        }

        public static explicit operator CPUCooler(CPUCoolerViewModel CPUCoolerViewModel)
        {
            var CPUCooler = new CPUCooler
            {
                Id = CPUCoolerViewModel.Id,
                ImageData = CPUCoolerViewModel.ImageData,
                DateCreate = CPUCoolerViewModel.DateCreate,
                Name = CPUCoolerViewModel.Name,
                TDP = CPUCoolerViewModel.TDP,
                Height = CPUCoolerViewModel.Height
            };

            System.Enum.TryParse(CPUCoolerViewModel.Company, out Company company);
            CPUCooler.Company = company;

            return CPUCooler;
        }

        public void CopyToModel(ref CPUCooler model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;

            model.TDP = TDP;
            model.Height = Height;
        }
    }
}
