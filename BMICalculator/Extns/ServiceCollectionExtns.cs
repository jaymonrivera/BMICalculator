using BMICalculator.Services;

namespace BMICalculator.Extns;

public static class ServiceCollectionExtns
{
    public static IServiceCollection ConfigureBMIServices(this IServiceCollection services)
    {
        services.AddScoped<IBMICalculator, BMICalculatorService>();
        return services;
    }
}
