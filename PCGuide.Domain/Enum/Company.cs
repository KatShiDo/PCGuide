using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.Enum
{
    public enum Company
    {
        [Display(Name = "AMD")]
        AMD = 0,
        [Display(Name = "Intel")]
        Intel = 1,
        [Display(Name = "NVIDIA")]
        NVIDIA = 2,
        [Display(Name = "Samsung")]
        Samsung = 3,
        [Display(Name = "Qualcomm")]
        Qualcomm = 4,
        [Display(Name = "Apple")]
        Apple = 5,
        [Display(Name = "CoolerMaster")]
        CoolerMaster = 6,
        [Display(Name = "BeQuiet")]
        BeQuiet = 7,
        [Display(Name = "HyperX")]
        HyperX = 8,
        [Display(Name = "FractalDesign")]
        FractalDesign = 9,
        [Display(Name = "Chieftec")]
        Chieftec = 10,
        [Display(Name = "Palit")]
        Palit = 11,
        [Display(Name = "Asus")]
        Asus = 12,
        [Display(Name = "Acer")]
        Acer = 13,
        [Display(Name = "Seagate")]
        Seagate = 14,
        [Display(Name = "WD")]
        WD = 15,
        [Display(Name = "Gigabyte")]
        Gigabyte = 16
    }
}
