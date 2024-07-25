namespace BMICalculator.Extns;

public static class CommonExtns
{
    public static float Round(this float value, int decimalPlaces)
    {
        if (decimalPlaces < 0)
        {
            throw new ArgumentException("Decimal places cannot be negative.", nameof(decimalPlaces));
        }
        return (float)Math.Round(value, decimalPlaces);
    }
}
