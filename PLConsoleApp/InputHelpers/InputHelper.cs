using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLConsoleApp.InputHelpers
{
    internal static class InputHelper
    {
        internal static double RetrieveDoubleValue(string message)
        {
            Console.WriteLine(message);
            string? inputValue = Console.ReadLine();
            bool validity = double.TryParse(inputValue, out double value);
            if (validity && value >= 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid format, try again");
                return RetrieveDoubleValue(message);
            }
        }

        internal static int RetrieveIntValue(string message)
        {
            Console.WriteLine(message);
            string? inputValue = Console.ReadLine();
            bool validity = int.TryParse(inputValue, out int value);
            if (validity && value >= 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid format, try again");
                return RetrieveIntValue(message);
            }
        }
    }
}
