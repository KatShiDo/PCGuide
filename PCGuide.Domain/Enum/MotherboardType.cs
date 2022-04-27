using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum MotherboardType
    {
        [Display(Name = "mini-ATX")]
        mini_ATX = 0,
        [Display(Name = "micro-ATX")]
        micro_ATX = 1,
        [Display(Name = "ATX")]
        ATX = 2,
        [Display(Name = "E-ATX")]
        E_ATX = 3
    }
}
