using Microsoft.AspNetCore.Mvc;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PressureLossesController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public PressureLossesController(ICalculator calculator)
        {
            _calculator = calculator;
        }


        // GET api/PressureLosses/5
        [HttpGet("{diameter}")]
        public string Get(double diameter)
        {
            InputData inputData = new InputData(1,diameter,1,100,1,1,1);
            IResults result = _calculator.Calculate(inputData);
            return result.FrictionalPressureLoss.ToString();
        }

    }
}
