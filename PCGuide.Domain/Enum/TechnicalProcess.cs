using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum TechnicalProcess
    {
        [Display(Name = "Intel 14nm")]
        Intel14nm = 0,
        [Display(Name = "Intel 10nm")]
        Intel10nm = 1,
        [Display(Name = "TSMC 7nm")]
        TSMC7nm = 2,
        [Display(Name = "TSMC 6nm")]
        TSMC6nm = 3,
        [Display(Name = "TSMC 5nm")]
        TSMC5nm = 4,
        [Display(Name = "Apple 5nm")]
        Apple5nm = 5,
        [Display(Name = "Samsung 7nm")]
        Samsung7nm = 6,
        [Display(Name = "Samsung 5nm")]
        Samsung5nm = 7,
        [Display(Name = "Qualcomm 5nm")]
        Qualcomm5nm = 8,
        [Display(Name = "Qualcomm 4nm")]
        Qualcomm4nm = 9
    }
}
