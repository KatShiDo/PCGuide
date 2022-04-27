using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum Series
    {
        [Display(Name = "Ryzen Vermeer")]
        RyzenVermeer = 0,
        [Display(Name = "Ryzen Cezanne")]
        RyzenCezanne = 1,
        [Display(Name = "Intel Comet Lake")]
        IntelCometLake = 2,
        [Display(Name = "Intel Alder Lake")]
        IntelAlderLake = 3,
        [Display(Name = "NVIDIA Pascal")]
        NVIDIAPascal = 4,
        [Display(Name = "NVIDIA Turing")]
        NVIDIATuring = 5,
        [Display(Name = "NVIDIA Amper")]
        NVIDIAAmper = 6
    }
}
