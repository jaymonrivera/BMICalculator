namespace BMICalculator.DTOs;

public record BMIResultDto
{
    public float BMI { get; set; }
    public string? Category { get; set; }
}
