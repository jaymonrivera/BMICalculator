using BMICalculator.DTOs;
using BMICalculator.Extns;
using BMICalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace BMICalculator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BMIController : ControllerBase
{
    private readonly IBMICalculator _bmiCalculator;

    public BMIController(IBMICalculator bmiCalculator)
    {
        _bmiCalculator = bmiCalculator;
    }

    [HttpPost]
    public IActionResult CalculateBMI([FromBody] BMIRequestDto request)
    {
        if (request.Weight <= 0 || request.Height <= 0)
        {
            return BadRequest("Weight and height must be greater than zero.");
        }

        float bmi;
        try
        {
            bmi = _bmiCalculator.CalculateBMI(request.Weight, request.Height);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }

        var category = _bmiCalculator.GetBMICategory(bmi);

        var result = new BMIResultDto
        {
            BMI = bmi,
            Category = category.GetDisplayName(),
        };

        return Ok(result);
    }
}