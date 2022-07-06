using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class PowerUnitViewModel : PCPartViewModel
    {
        [Display(Name = "Мощность")]
        [Required(ErrorMessage = "Введите мощность")]
        public ushort Power { get; set; }

        public static explicit operator PowerUnitViewModel(PowerUnit powerUnit)
        {
            return new PowerUnitViewModel
            {
                Id = powerUnit.Id,
                ImageData = powerUnit.ImageData,
                DateCreate = powerUnit.DateCreate,
                Name = powerUnit.Name,
                Company = powerUnit.Company.ToString(),
                Power = powerUnit.Power
            };
        }

        public static explicit operator PowerUnit(PowerUnitViewModel powerUnitViewModel)
        {
            var powerUnit = new PowerUnit
            {
                Id = powerUnitViewModel.Id,
                ImageData = powerUnitViewModel.ImageData,
                DateCreate = powerUnitViewModel.DateCreate,
                Name = powerUnitViewModel.Name,
                Power = powerUnitViewModel.Power
            };

            System.Enum.TryParse(powerUnitViewModel.Company, out Company company);
            powerUnit.Company = company;

            return powerUnit;
        }

        public void CopyToModel(ref PowerUnit model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;
            model.Power = Power;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;
        }
    }
}
