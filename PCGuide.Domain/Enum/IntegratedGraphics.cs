using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum IntegratedGraphics
    {
        [Display(Name = "Intel UHD 630")]
        UHD630 = 0,
        [Display(Name = "Intel UHD 730")]
        UHD730 = 1,
        [Display(Name = "Vega 7")]
        Vega7 = 2,
        [Display(Name = "Vega 8")]
        Vega8 = 3
    }
}
