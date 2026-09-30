using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.AddSingleton<AppDbContext>();

services.AddSingleton<ICalculatorService, CalculatorService>();

services.AddSingleton<ICalculationRepository, CalculationRepository>();

services.AddSingleton<CalculatorUI>();

services.AddSingleton<CalculatorApp>();

ServiceProvider serviceProvider = services.BuildServiceProvider();

CalculatorApp app =
    serviceProvider.GetRequiredService<CalculatorApp>();

app.Run();