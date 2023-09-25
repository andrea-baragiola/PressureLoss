using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

namespace PLConsoleApp.InputHelpers
{
    internal static class InputHelper
    {
        internal static List<IResults> GetPipesInputs()
        {
            List<IResults> ResultsList = new List<IResults>();

            while (true)
            {
                InputData inputData = GetIndividualPipeInputs();

                IResults results = HazenWilliamsCalculator.ResultsHazenWilliamsCalculate(inputData);

                ResultsList.Add(results);

                Console.WriteLine("Do you want to add another pipe? (y/n)");
                string answer = Console.ReadLine();
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Unacceptable answer. Do you want to add another pipe? (y/n)");
                    answer = Console.ReadLine();
                }
                if (answer == "n") break;
            }

            return ResultsList;
        }

        internal static InputData GetIndividualPipeInputs()
        {
            double pipeLenght = RetrieveDoubleValue("Pipe lenght (m):");
            double pipeDiameter = RetrieveDoubleValue("Pipe internal diameter (mm):");
            double waterFlowRate = RetrieveDoubleValue("Water flow rate (l/s):");
            double pipeSurfaceFactor = RetrieveDoubleValue("Pipe Surface Factor:");
            int numberOf90DegCurves = RetrieveIntValue("Number Of 90° Curves:");
            int numberOf45DegCurves = RetrieveIntValue("Number Of 45° Curves:");
            int numberOfTJunctions = RetrieveIntValue("Number Of T Junctions:");

            InputData inputData = new InputData
                (pipeLenght, pipeDiameter, waterFlowRate, pipeSurfaceFactor, numberOf90DegCurves, numberOf45DegCurves, numberOfTJunctions);
            return inputData;
        }

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
