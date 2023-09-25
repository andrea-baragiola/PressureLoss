using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PressureLossCalculations.Models;

namespace PressureLossCalculations.Services
{
    public static class HazenWilliamsCalculator
    {

        public static ResultsHazenWilliams ResultsHazenWilliamsCalculate(InputData inputData)
        {

            // FRICTIONAL LOSSES
            double unitaryFrictionalPressureLoss =
                10.67 * Math.Pow(inputData.WaterFlowRate / 1000, 1.85) /
                (Math.Pow(inputData.PipeSurfaceFactor, 1.85) * Math.Pow(inputData.PipeDiameter / 1000, 4.86));
            double frictionalPressureLoss = unitaryFrictionalPressureLoss * inputData.PipeLength;

            // LOCAL LOSSES
            double equivalentLength = 0;
            LocalLosses localLosses = new LocalLosses();

            int row = 0;
            while (true) if (inputData.PipeDiameter < localLosses.LocalLosses2DArray[0][row]) break; else row++;

            if (inputData.NumberOf45DegCurves > 0) equivalentLength += inputData.NumberOf45DegCurves * localLosses.LocalLosses2DArray[1][row];
            if (inputData.NumberOf90DegCurves > 0) equivalentLength += inputData.NumberOf90DegCurves * localLosses.LocalLosses2DArray[2][row];
            if (inputData.NumberOfTJunctions > 0) equivalentLength += inputData.NumberOfTJunctions * localLosses.LocalLosses2DArray[4][row];

            double localPressureLoss = unitaryFrictionalPressureLoss * equivalentLength;
            double totalPressureLoss = frictionalPressureLoss + localPressureLoss;

            // GENERATE RESULTS
            ResultsHazenWilliams resultsHazenWilliams = new ResultsHazenWilliams(
                inputData,
                totalPressureLoss,
                unitaryFrictionalPressureLoss,
                frictionalPressureLoss,
                localPressureLoss,
                equivalentLength);

            return resultsHazenWilliams;

        }
    }
}
