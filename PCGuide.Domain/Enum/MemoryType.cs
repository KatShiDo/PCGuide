using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum MemoryType
    {
        [Display(Name = "DDR3")]
        DDR3 = 0,
        [Display(Name = "DDR4")]
        DDR4 = 1,
        [Display(Name = "DDR5")]
        DDR5 = 2,
        [Display(Name = "GDDR5")]
        GDDR5 = 3,
        [Display(Name = "GDDR6")]
        GDDR6 = 4,
        [Display(Name = "GDDR6X")]
        GDDR6X = 5
    }
}
