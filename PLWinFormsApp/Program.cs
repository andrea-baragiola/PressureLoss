using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using PLWinFormsApp.Helpers;
using PressureLossCalculations.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PLWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            var container = Startup.ConfigureService();
            var calculator = container.GetRequiredService<ICalculator>();

            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PressureLossApp(calculator));
        }
    }
}