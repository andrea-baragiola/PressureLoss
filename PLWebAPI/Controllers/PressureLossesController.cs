using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;
using DataAccess.DbAccess;
using DataAccess.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class PressureLossesController : ControllerBase
    {
        private readonly ICalculator _calculator;
        private readonly IDataAccessHelper _dataAccessHelper;

        public PressureLossesController(ICalculator calculator, IDataAccessHelper dataAccessHelper)
        {
            _calculator = calculator;
            _dataAccessHelper = dataAccessHelper;
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

        // GET TEST SQL
        [HttpGet]
        public async Task<string> GetDbTestAsync()
        {
            IEnumerable<Person> personList = await _dataAccessHelper.GetPeopleAsync();
            return JsonSerializer.Serialize(personList);
        }
    }
}
