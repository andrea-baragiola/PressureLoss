using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureLossCalculations.Models
{
    public class InputData
    {
        public double PipeLength { get; set; } // m
        public double PipeDiameter { get; set; } // mm
        public double WaterFlowRate { get; set; } // l/s
        public double PipeSurfaceFactor { get; set; } // l/s
        public int NumberOf90DegCurves { get; set; }
        public int NumberOf45DegCurves { get; set; }
        public int NumberOfTJunctions { get; set; }

        public InputData()
        {
            
        }

        public InputData(double length, double diameter, double waterFlowRate, double pipeSurfaceFactor, int numberOf90DegCurves, int numberOf45DegCurves, int numberOfTJunctions)
        {
            PipeLength = length;
            PipeDiameter = diameter;
            WaterFlowRate = waterFlowRate;
            PipeSurfaceFactor = pipeSurfaceFactor;
            NumberOf90DegCurves = numberOf90DegCurves;
            NumberOf45DegCurves = numberOf45DegCurves;
            NumberOfTJunctions = numberOfTJunctions;
        }

    }
}
