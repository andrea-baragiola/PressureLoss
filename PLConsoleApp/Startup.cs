using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

namespace PLConsoleApp
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddSingleton<ICalculator, HazenWilliamsCalculator>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
