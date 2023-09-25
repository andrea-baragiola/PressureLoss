using PressureLossCalculations.Models;

namespace PressureLossCalculations.Services
{
    public interface ICalculator
    {
        IResults Calculate(InputData inputData);
    }
}