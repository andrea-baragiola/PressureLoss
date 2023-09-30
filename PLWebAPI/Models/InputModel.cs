// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLWebAPI.Controllers
{
    public partial class PressureLossesController
    {
        public class InputModel
        {
            public double Length { get; set; }
            public double Diameter { get; set; }
            public double WaterFlowRate { get; set; }
            public double PipeSurfaceFactor { get; set; }
            public int NumberOf90DegCurves { get; set; }
            public int NumberOf45DegCurves { get; set; }
            public int NumberOfTJunctions { get; set; }
        }

    }
}
