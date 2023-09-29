using PressureLossCalculations.Models;

namespace PLWinFormsApp.Helpers
{
    internal class NumericalInputsHelpers
    {
        internal static void GetAndValidateRowInputs
                (DataGridViewRow row, out InputData inputData, out List<Tuple<string, int>> rowErrorCohordinates)
        {
            rowErrorCohordinates = new List<Tuple<string, int>>
            {
                RetrieveDoubleValue(row, "PipeLength", out double pipeLength),
                RetrieveDoubleValue(row, "PipeDiameter", out double pipeDiameter),
                RetrieveDoubleValue(row, "PipeSurfaceFactor", out double pipeSurfaceFactor),
                RetrieveDoubleValue(row, "WaterFlowRate", out double waterFlowRate),
                RetrieveIntValue(row, "NumberOf90DegCurves", out int NumberOf90DegCurves),
                RetrieveIntValue(row, "NumberOf45DegCurves", out int NumberOf45DegCurves),
                RetrieveIntValue(row, "NumberOfTJunctions", out int NumberOfTJunctions)
            };

            inputData = new InputData
                (pipeLength, pipeDiameter, waterFlowRate, pipeSurfaceFactor, NumberOf90DegCurves, NumberOf45DegCurves, NumberOfTJunctions);

        }

        internal static Tuple<string, int> RetrieveDoubleValue(DataGridViewRow row, string columnName, out double value)
        {
            bool parseValidity = double.TryParse(row.Cells[columnName].Value.ToString(), out value);
            if (!parseValidity || value <= 0)
            {
                return new Tuple<string, int>(columnName, row.Index);
            }
            else
            {
                return null;
            }

        }

        internal static Tuple<string, int> RetrieveIntValue(DataGridViewRow row, string columnName, out int value)
        {
            bool parseValidity = int.TryParse(row.Cells[columnName].Value.ToString(), out value);
            if (!parseValidity || value < 0)
            {
                return new Tuple<string, int>(columnName, row.Index);
            }
            else
            {
                return null;
            }

        }
    }
}