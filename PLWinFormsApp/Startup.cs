﻿using Microsoft.Extensions.DependencyInjection;
using PressureLossCalculations.Services;

namespace PLWinFormsApp
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddTransient<PressureLossApp>()
                .AddSingleton<ICalculator, HazenWilliamsCalculator>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
