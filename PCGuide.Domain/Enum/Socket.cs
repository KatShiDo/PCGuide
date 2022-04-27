using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum Socket
    {
        [Display(Name = "AM3")]
        AM3 = 0,
        [Display(Name = "AM4")]
        AM4 = 1,
        [Display(Name = "AM5")]
        AM5 = 2,
        [Display(Name = "LGA1200")]
        LGA1200 = 3,
        [Display(Name = "LGA1700")]
        LGA1700 = 4
    }
}
