namespace PressureLossCalculations
{
    public interface IResults
    {

        double UnitaryFrictionalPressureLoss { get; set; }
        double FrictionalPressureLoss { get; set; }
        double LocalPressureLoss { get; set; }
        double TotalPressureLoss { get; set; }
        double EquivalentLength { get; set; }
    }
}