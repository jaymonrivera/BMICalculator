using BMICalculator.Contants;
using BMICalculator.Enums;
using BMICalculator.Extns;

namespace BMICalculator.Services;

public class BMICalculatorService : IBMICalculator
{
    public float GetBMIValue(float weight, float height)
    {
        if (weight <= 0 || height <= 0)
        {
            throw new ArgumentException(ErrorMessages.WeightAndHeightGreaterThanZero);
        }

        float heightInMeters = ConvertHeightToMeters(height);
        return CalculateBMIValue(weight, heightInMeters).Round(2);
    }

    public BMICategory GetBMICategory(float bmi)
    {
        if (bmi < 18.5) return BMICategory.Underweight;
        else if (bmi >= 18.5 && bmi < 24.9) return BMICategory.NormalWeight;
        else if (bmi >= 25 && bmi < 29.9) return BMICategory.Overweight;
        else return BMICategory.Obesity;
    }

    private float ConvertHeightToMeters(float heightInCm)
    {
        return heightInCm / 100;
    }

    private float CalculateBMIValue(float weight, float heightInMeters)
    {
        return weight / (heightInMeters * heightInMeters);
    }
}