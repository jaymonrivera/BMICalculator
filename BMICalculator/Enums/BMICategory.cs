using System.ComponentModel.DataAnnotations;

namespace BMICalculator.Enums;

public enum BMICategory
{
    [Display(Name = "Underweight")]
    Underweight,
    [Display(Name = "Normal weight")]
    NormalWeight,
    [Display(Name = "Overweight")]
    Overweight,
    [Display(Name = "Obesity")]
    Obesity
}
