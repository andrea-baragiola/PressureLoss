using System.Data.Common;
using System.Globalization;
using PLWinFormsApp.Helpers;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

namespace PLWinFormsApp
{

    public partial class PressureLossApp : Form
    {
        private readonly ICalculator _calculator;
        public PressureLossApp(ICalculator calculator)
        {
            _calculator = calculator;
            InitializeComponent();
        }

        private void inputDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Set default values for specific columns
            e.Row.Cells["Tratto"].Value = e.Row.Index + 1;
            e.Row.Cells["PipeLength"].Value = 0;
            e.Row.Cells["PipeDiameter"].Value = 0;
            e.Row.Cells["PipeSurfaceFactor"].Value = 0;
            e.Row.Cells["WaterFlowRate"].Value = 0;
            e.Row.Cells["NumberOf90DegCurves"].Value = 0;
            e.Row.Cells["NumberOf45DegCurves"].Value = 0;
            e.Row.Cells["NumberOfTJunctions"].Value = 0;
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            GraphicalHelpers.ResetInputsCellsColor(inputDataGridView);

            List<InputData> inputList;
            List<Tuple<string, int>> errorCohordinates;
            GetErrorCohordinates(out inputList, out errorCohordinates);

            if (errorCohordinates.Count == 0)
            {
                List<IResults> results = WinFormUILogic.GetAllResults(inputList, _calculator);
                GraphicalHelpers.ShowResults(results, resultDataGridView);
                AlertLabel.Text = string.Empty;
            }
            else
            {
                GraphicalHelpers.HighlightsMistakes(errorCohordinates, inputDataGridView, resultDataGridView);
                AlertLabel.Text = "Correct the highlighted values, then retry";
            }

            inputDataGridView.ClearSelection();


        }

        private void GetErrorCohordinates(out List<InputData> inputList, out List<Tuple<string, int>> errorCohordinates)
        {
            inputList = new List<InputData>();
            errorCohordinates = new List<Tuple<string, int>>();
            foreach (DataGridViewRow row in inputDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    NumericalInputsHelpers.GetAndValidateRowInputs(row, out InputData inputdata, out List<Tuple<string, int>> rowErrorCohordinates);
                    rowErrorCohordinates.RemoveAll(item => item == null);

                    if (rowErrorCohordinates.Count == 0)
                    {
                        inputList.Add(inputdata);
                    }
                    else
                    {
                        errorCohordinates.AddRange(rowErrorCohordinates);
                    }
                }
            }
            errorCohordinates.RemoveAll(item => item == null);
        }

        private void inputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == inputDataGridView.Columns["Delete"].Index)
            {
                inputDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}