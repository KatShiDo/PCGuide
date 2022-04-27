using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum Chipset
    {
        [Display(Name = "H410")]
        H410 = 0,
        [Display(Name = "B460")]
        B460 = 1,
        [Display(Name = "Z490")]
        Z490 = 2,
        [Display(Name = "H510")]
        H510 = 3,
        [Display(Name = "B560")]
        B560 = 4,
        [Display(Name = "Z590")]
        Z590 = 5,
        [Display(Name = "B450")]
        B450 = 6,
        [Display(Name = "X470")]
        X470 = 7,
        [Display(Name = "A520")]
        A520 = 8,
        [Display(Name = "B550")]
        B550 = 9,
        [Display(Name = "X570")]
        X570 = 10
    }
}
