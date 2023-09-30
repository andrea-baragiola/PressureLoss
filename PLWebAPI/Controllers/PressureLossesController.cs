using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class PressureLossesController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public PressureLossesController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        // POST api/PressureLosses
        [HttpPost]
        public string CalculatePressureLosses([FromBody] InputModel inputModel)
        {
            InputData inputData = new InputData(inputModel.Length,
                                                inputModel.Diameter,
                                                inputModel.WaterFlowRate,
                                                inputModel.PipeSurfaceFactor,
                                                inputModel.NumberOf90DegCurves,
                                                inputModel.NumberOf45DegCurves,
                                                inputModel.NumberOfTJunctions);
            IResults result = _calculator.Calculate(inputData);
            return JsonSerializer.Serialize(result);
        }

    }
}
