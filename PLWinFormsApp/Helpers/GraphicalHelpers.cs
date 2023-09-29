using PressureLossCalculations.Models;

internal static class GraphicalHelpers
{

    internal static void HighlightsMistakes
        (List<Tuple<string, int>> errorCohordinates, DataGridView inputDataGridView, DataGridView resultDataGridView)
    {
        foreach (Tuple<string, int> cohordinate in errorCohordinates)
        {

            DataGridViewColumn column = inputDataGridView.Columns[cohordinate.Item1];
            DataGridViewCell cell = inputDataGridView[column.Index, cohordinate.Item2];
            cell.Style.BackColor = Color.LightSalmon;

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
}