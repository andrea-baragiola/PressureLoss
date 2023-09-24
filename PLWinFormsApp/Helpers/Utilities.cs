using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PressureLossCalculations;
using PressureLossCalculations.Calculations;
using PressureLossCalculations.Models;

namespace PLWinFormsApp.Helpers
{
    internal class Utilities
    {
        internal static void GetAndValidateRowInputs
            (DataGridViewRow row, out InputData inputData, out List<Tuple<string, int>> rowErrorCohordinates)
        {
            rowErrorCohordinates = new List<Tuple<string, int>>
            {
                NumericalInputsHelpers.RetrieveDoubleValue(row, "PipeLength", out double pipeLength),
                NumericalInputsHelpers.RetrieveDoubleValue(row, "PipeDiameter", out double pipeDiameter),
                NumericalInputsHelpers.RetrieveDoubleValue(row, "PipeSurfaceFactor", out double pipeSurfaceFactor),
                NumericalInputsHelpers.RetrieveDoubleValue(row, "WaterFlowRate", out double waterFlowRate),
                NumericalInputsHelpers.RetrieveIntValue(row, "NumberOf90DegCurves", out int NumberOf90DegCurves),
                NumericalInputsHelpers.RetrieveIntValue(row, "NumberOf45DegCurves", out int NumberOf45DegCurves),
                NumericalInputsHelpers.RetrieveIntValue(row, "NumberOfTJunctions", out int NumberOfTJunctions)
            };

            inputData = new InputData
                (pipeLength, pipeDiameter, waterFlowRate, pipeSurfaceFactor, NumberOf90DegCurves, NumberOf45DegCurves, NumberOfTJunctions);

        }

        internal static List<IResults> GetAllResults(List<InputData> inputList)
        {
            List<IResults> results = new List<IResults>();

            foreach (InputData input in inputList)
            {
                IResults result = new ResultsHazenWilliams(input);
                results.Add(result);
            }
            return results;
        }
    }
}
