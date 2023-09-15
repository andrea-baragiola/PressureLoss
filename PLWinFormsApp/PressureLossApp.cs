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
            List<InputData> inputList = new List<InputData>();
            List<Tuple<string, int>> errorCohordinates = new List<Tuple<string, int>>();

            foreach (DataGridViewRow row in inputDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    // provo a prendere i valori, in caso di errore ritorno false e errori
                    GetAndValidateRowInputs(row, out InputData inputdata, out List<Tuple<string, int>> rowErrorCohordinates);
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
                outputText.Text = "andato bene";
            }
            else
            {
                outputText.Text = "andato male";
            }


        }

        void GetAndValidateRowInputs(DataGridViewRow row, out InputData inputData, out List<Tuple<string, int>> rowErrorCohordinates)
        {
            rowErrorCohordinates = new List<Tuple<string, int>>();
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "PipeLength", out double pipeLength));
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "PipeDiameter", out double pipeDiameter));
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "PipeSurfaceFactor", out double pipeSurfaceFactor));
            rowErrorCohordinates.Add(RetrieveDoubleValue(row, "WaterFlowRate", out double waterFlowRate));

            inputData = new InputData(pipeLength, pipeDiameter, pipeSurfaceFactor, waterFlowRate, 0, 0, 0);


        }

        Tuple<string, int> RetrieveDoubleValue(DataGridViewRow row, string columnName, out double value)
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


    }
}