namespace PLWinFormsApp.Helpers
{
    internal static class NumericalInputsHelpers
    {

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