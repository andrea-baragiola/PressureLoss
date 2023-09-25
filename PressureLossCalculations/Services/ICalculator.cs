using PressureLossCalculations.Models;

namespace PressureLossCalculations.Services
{
    public interface ICalculator
    {
        ResultsHazenWilliams Calculate(InputData inputData);
    }
}