using Microsoft.Extensions.DependencyInjection;
using PLConsoleApp.UILogic;
using PressureLossCalculations.Services;

namespace PLConsoleApp
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddTransient<ConsoleUILogic>()
                .AddTransient<ICalculator, HazenWilliamsCalculator>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
