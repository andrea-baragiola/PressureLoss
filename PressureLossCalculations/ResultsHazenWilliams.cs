using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureLossCalculations
{
    public class ResultsHazenWilliams : IResults
    {
        public InputData InputData { get; set; }
        public double TotalPressureLoss { get; set; }
        public double UnitaryFrictionalPressureLoss { get; set; }
        public double FrictionalPressureLoss { get; set; }
        public double LocalPressureLoss { get; set; }
        public double EquivalentLength { get; set; }

        public ResultsHazenWilliams(InputData inputData)
        {
            InputData = inputData;

            // FRICTIONAL LOSSES
            UnitaryFrictionalPressureLoss =
                10.67 * Math.Pow(inputData.WaterFlowRate/1000, 1.85) / 
                (Math.Pow(inputData.PipeSurfaceFactor, 1.85) * Math.Pow(inputData.PipeDiameter/1000, 4.86));
            FrictionalPressureLoss = UnitaryFrictionalPressureLoss * inputData.PipeLength;

            // LOCAL LOSSES
            LocalLosses localLosses = new LocalLosses();
            int row = 0;
            while (true) if (inputData.PipeDiameter < localLosses.LocalLosses2DArray[0][row]) break; else row++;

            if (inputData.NumberOf45DegCurves > 0) EquivalentLength += inputData.NumberOf45DegCurves * localLosses.LocalLosses2DArray[1][row];
            if (inputData.NumberOf90DegCurves > 0) EquivalentLength += inputData.NumberOf90DegCurves * localLosses.LocalLosses2DArray[2][row];
            if (inputData.NumberOfTJunctions > 0) EquivalentLength += inputData.NumberOfTJunctions * localLosses.LocalLosses2DArray[4][row];

            LocalPressureLoss = UnitaryFrictionalPressureLoss * EquivalentLength;
            TotalPressureLoss = FrictionalPressureLoss + LocalPressureLoss;

        }
    }
}
