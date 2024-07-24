namespace BMICalculator.DTOs;

public record BMIRequestDto
{
    public float Weight { get; set; }
    public float Height { get; set; }
}
