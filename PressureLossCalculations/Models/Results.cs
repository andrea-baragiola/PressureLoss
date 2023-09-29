using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureLossCalculations.Models
{
    public class Results : IResults
    {
        public InputData InputData { get; set; }
        public double TotalPressureLoss { get; set; }
        public double UnitaryFrictionalPressureLoss { get; set; }
        public double FrictionalPressureLoss { get; set; }
        public double LocalPressureLoss { get; set; }
        public double EquivalentLength { get; set; }

        public Results(
            InputData inputData,
            double totalPressureLoss,
            double unitaryFrictionalPressureLoss,
            double frictionalPressureLoss,
            double localPressureLoss,
            double equivalentLength)
        {
            InputData = inputData;
            TotalPressureLoss = totalPressureLoss;
            UnitaryFrictionalPressureLoss = unitaryFrictionalPressureLoss;
            FrictionalPressureLoss = frictionalPressureLoss;
            LocalPressureLoss = localPressureLoss;
            EquivalentLength = equivalentLength;

        }
    }
}
