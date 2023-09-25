using PressureLossCalculations.Models;

namespace PLConsoleApp.InputHelpers
{
    internal static class OutputHelper
    {
        internal static void PrintResults(List<IResults> ResultsList)
        {
            Console.Write("Tratti:".PadRight(20)); Console.Write("PdC lin.".PadRight(20)); Console.Write("PdC loc.".PadRight(20)); Console.Write("PdC tot.".PadRight(20)); Console.WriteLine();

            int i = 1;
            foreach (IResults results in ResultsList)
            {

                Console.Write(i.ToString().PadRight(20));
                Console.Write(results.FrictionalPressureLoss.ToString("#.##").PadRight(20));
                Console.Write(results.LocalPressureLoss.ToString("#.##").PadRight(20));
                Console.Write(results.TotalPressureLoss.ToString("#.##").PadRight(20));
                Console.WriteLine();
                i++;
            }
        }
    }
}
