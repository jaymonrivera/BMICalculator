using BMICalculator.Contants;
using BMICalculator.Controllers;
using BMICalculator.DTOs;
using BMICalculator.Enums;
using BMICalculator.Extns;
using BMICalculator.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace BMICalculator.Tests.Controllers
{
    [TestFixture]
    public class BMIControllerTests
    {
        private Mock<IBMICalculator> _mockBmiCalculator;
        private BMIController _controller;

        [SetUp]
        public void SetUp()
        {
            _mockBmiCalculator = new Mock<IBMICalculator>();
            _controller = new BMIController(_mockBmiCalculator.Object);
        }

        [Test]
        public void CalculateBMI_WithValidInputs_ShouldReturnOkResult()
        {
            var expectedBMIValue = 24.1f;
            var expectedCategory = BMICategory.NormalWeight;

            var request = new BMIRequestDto { Weight = 68, Height = 168 };
            _mockBmiCalculator.Setup(service => service.GetBMIValue(It.IsAny<float>(), It.IsAny<float>()))
                .Returns(24.1f);
            _mockBmiCalculator.Setup(service => service.GetBMICategory(It.IsAny<float>()))
                .Returns(expectedCategory);


            var result = _controller.CalculateBMI(request) as OkObjectResult;


            Assert.NotNull(result);
            var resultValue = result.Value as BMIResultDto;
            Assert.NotNull(resultValue);
            Assert.That(resultValue.BMI, Is.EqualTo(expectedBMIValue));
            Assert.That(resultValue.Category, Is.EqualTo(expectedCategory.GetDisplayName()));
        }

        [Test]
        public void CalculateBMI_WithInvalidInputs_ShouldReturnBadRequest()
        {
            var request = new BMIRequestDto { Weight = 0, Height = -1 };

            var result = _controller.CalculateBMI(request) as BadRequestObjectResult;

            Assert.NotNull(result);
            Assert.That(result.Value, Is.EqualTo(ErrorMessages.WeightAndHeightGreaterThanZero));
        }
    }
}
