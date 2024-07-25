using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BMICalculator.Extns;

public static class EnumExtensions
{
    public static string? GetDisplayName(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());

        if(fieldInfo is null)
            return null;

        var attribute = fieldInfo.GetCustomAttribute<DisplayAttribute>();

        return attribute != null ? attribute.Name : value.ToString();
    }
}
