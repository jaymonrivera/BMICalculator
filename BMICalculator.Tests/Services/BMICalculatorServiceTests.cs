using BMICalculator.Enums;
using BMICalculator.Services;


namespace BMICalculator.Tests.Services;

[TestFixture]
public class BMICalculatorServiceTests
{
    private BMICalculatorService _bmiCalculatorService;

    [SetUp]
    public void SetUp()
    {
        _bmiCalculatorService = new BMICalculatorService();
    }

    [TestCase(68, 168, 24.09f)]
    [TestCase(100, 168, 35.43f)]
    public void CalculateBMI_ShouldReturnCorrectBMI(float weight, float height, float expectedBmi)
    {
        var result = _bmiCalculatorService.GetBMIValue(weight, height);

        Assert.That(result, Is.EqualTo(expectedBmi).Within(0.01f));
    }

    [TestCase(17.50f, BMICategory.Underweight)]
    [TestCase(24.90f, BMICategory.NormalWeight)]
    [TestCase(29.90f, BMICategory.Overweight)]
    [TestCase(30.10f, BMICategory.Obesity)]
    public void GetBMICategory_ShouldReturnCorrectCategory(float bmi, BMICategory expectedCategory)
    {
        var result = _bmiCalculatorService.GetBMICategory(bmi);

        Assert.That(result, Is.EqualTo(expectedCategory));
    }

    [Test]
    public void CalculateBMI_WithInvalidInputs_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _bmiCalculatorService.GetBMIValue(0f, 0f));
        Assert.Throws<ArgumentException>(() => _bmiCalculatorService.GetBMIValue(70f, 0f));
        Assert.Throws<ArgumentException>(() => _bmiCalculatorService.GetBMIValue(-1f, 1.75f));
        Assert.Throws<ArgumentException>(() => _bmiCalculatorService.GetBMIValue(70f, -1f));
    }
}