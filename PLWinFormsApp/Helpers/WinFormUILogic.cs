using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

namespace PLWinFormsApp.Helpers
{
    internal class WinFormUILogic
    {

        internal static List<IResults> GetAllResults(List<InputData> inputList, ICalculator _calculator)
        {
            List<IResults> results = new List<IResults>();

            foreach (InputData input in inputList)
            {
                IResults result = _calculator.Calculate(input);
                results.Add(result);
            }
            return results;
        }
    }
}
