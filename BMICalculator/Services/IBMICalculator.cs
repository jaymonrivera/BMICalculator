using BMICalculator.Enums;

namespace BMICalculator.Services;

public interface IBMICalculator
{
    public float GetBMIValue(float weight, float height);
    public BMICategory GetBMICategory(float bmi);
}
