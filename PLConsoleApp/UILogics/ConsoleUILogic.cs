using PLConsoleApp.InputHelpers;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

namespace PLConsoleApp.UILogic
{
    public class ConsoleUILogic
    {
        private readonly ICalculator _calculator;
        public ConsoleUILogic(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public List<IResults> GetInputsAndCalculate()
        {
            List<IResults> ResultsList = new List<IResults>();

            while (true)
            {
                InputData inputData = InputHelper.GetIndividualPipeInputs();

                IResults results = _calculator.Calculate(inputData);

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
    }
}
