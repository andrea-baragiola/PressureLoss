using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using PLConsoleApp;
using PLConsoleApp.InputHelpers;
using PLConsoleApp.UILogic;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

var container = Startup.ConfigureService();
var calculator = container.GetRequiredService<ICalculator>();

UILogic uilogic = new UILogic(calculator);

List<IResults> ResultsList = uilogic.GetInputsAndCalculate();

OutputHelper.PrintResults(ResultsList);
