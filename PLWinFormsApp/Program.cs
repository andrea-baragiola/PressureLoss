using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
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

            ApplicationConfiguration.Initialize();
            Application.Run(container.GetRequiredService<PressureLossApp>());
        }
    }
}