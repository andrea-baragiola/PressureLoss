using System.Data.Common;
using System.Globalization;
using PressureLossCalculations;

namespace PLWinFormsApp
{

    public partial class PressureLossApp : Form
    {

        public PressureLossApp()
        {
            InitializeComponent();

        }

        private void inputDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Set default values for specific columns
            e.Row.Cells["Tratto"].Value = e.Row.Index + 1;
            e.Row.Cells["PipeLength"].Value = 0;
            e.Row.Cells["PipeDiameter"].Value = 20;
            e.Row.Cells["PipeSurfaceFactor"].Value = 100;
            e.Row.Cells["WaterFlowRate"].Value = 0;
            e.Row.Cells["NumberOf90DegCurves"].Value = 0;
            e.Row.Cells["NumberOf45DegCurves"].Value = 0;
            e.Row.Cells["NumberOfTJunctions"].Value = 0;
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetInputsCellsColor(inputDataGridView);

            List<InputData> inputList = new List<InputData>();
            List<Tuple<string, int>> errorCohordinates = new List<Tuple<string, int>>();

            foreach (DataGridViewRow row in inputDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Utilities.GetAndValidateRowInputs(row, out InputData inputdata, out List<Tuple<string, int>> rowErrorCohordinates);
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

            if (errorCohordinates.Count == 0)
            {
                List<IResults> results = Utilities.GetAllResults(inputList);
                Utilities.ShowResults(results, resultDataGridView);
            }
            else
            {
                Utilities.HighlightsMistakes(errorCohordinates, inputDataGridView, resultDataGridView);
            }

            inputDataGridView.ClearSelection();


        }


    }
}