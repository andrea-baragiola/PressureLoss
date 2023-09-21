using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PressureLossCalculations;
using PressureLossCalculations.Models;

namespace PLWinFormsApp
{
    internal class Utilities
    {
        internal static void ShowResults(List<IResults> results, DataGridView resultDataGridView)
        {
            resultDataGridView.Rows.Clear();

            int i = 0;
            foreach (IResults result in results)
            {

                resultDataGridView.Rows.Add();
                resultDataGridView.Rows[i].Cells["RTratto"].Value = 1 + i;
                resultDataGridView.Rows[i].Cells["RPipeLength"].Value = result.InputData.PipeLength.ToString("#.##");
                resultDataGridView.Rows[i].Cells["RPipeDiameter"].Value = result.InputData.PipeDiameter.ToString("#.##");
                resultDataGridView.Rows[i].Cells["RWaterFlowRate"].Value = result.InputData.WaterFlowRate.ToString("#.##");
                resultDataGridView.Rows[i].Cells["UnitaryFrictionalPressureLoss"].Value = result.UnitaryFrictionalPressureLoss.ToString("#.##");
                resultDataGridView.Rows[i].Cells["FrictionalPressureLoss"].Value = result.FrictionalPressureLoss.ToString("#.##");
                resultDataGridView.Rows[i].Cells["LocalPressureLoss"].Value = result.LocalPressureLoss.ToString("#.##");
                resultDataGridView.Rows[i].Cells["TotalPressureLoss"].Value = result.TotalPressureLoss.ToString("#.##");
                resultDataGridView.Rows[i].Cells["EquivalentLength"].Value = result.EquivalentLength.ToString("#.##");

                i++;


            }
        }

        internal static void GetAndValidateRowInputs
            (DataGridViewRow row, out InputData inputData, out List<Tuple<string, int>> rowErrorCohordinates)
        {
            rowErrorCohordinates = new List<Tuple<string, int>>();
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "PipeLength", out double pipeLength));
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "PipeDiameter", out double pipeDiameter));
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "PipeSurfaceFactor", out double pipeSurfaceFactor));
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "WaterFlowRate", out double waterFlowRate));

            rowErrorCohordinates.Add(RetrieveIntValue(row, "NumberOf90DegCurves", out int NumberOf90DegCurves));
            rowErrorCohordinates.Add(RetrieveIntValue(row, "NumberOf45DegCurves", out int NumberOf45DegCurves));
            rowErrorCohordinates.Add(RetrieveIntValue(row, "NumberOfTJunctions", out int NumberOfTJunctions));

            inputData = new InputData
                (pipeLength, pipeDiameter, waterFlowRate, pipeSurfaceFactor, NumberOf90DegCurves, NumberOf45DegCurves, NumberOfTJunctions);

        }

        internal static Tuple<string, int> RetrieveDoubleValue(DataGridViewRow row, string columnName, out double value)
        {
            bool parseValidity = double.TryParse(row.Cells[columnName].Value.ToString(), out value);
            if (!parseValidity || value < 0)
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

        internal static void HighlightsMistakes
            (List<Tuple<string, int>> errorCohordinates, DataGridView inputDataGridView, DataGridView resultDataGridView)
        {
            foreach (Tuple<string, int> cohordinate in errorCohordinates)
            {

                DataGridViewColumn column = inputDataGridView.Columns[cohordinate.Item1];
                DataGridViewCell cell = inputDataGridView[column.Index, cohordinate.Item2];
                cell.Style.BackColor = Color.LightYellow;
            }

            resultDataGridView.Rows.Clear();
        }

        internal static void ResetInputsCellsColor(DataGridView inputDataGridView)
        {
            foreach (DataGridViewRow row in inputDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = inputDataGridView.DefaultCellStyle.BackColor;
                    

                }
            }
        }
    }
}
