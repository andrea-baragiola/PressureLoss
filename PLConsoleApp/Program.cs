using System.Globalization;
using PLConsoleApp.InputHelpers;
using PLConsoleApp.UILogic;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

UILogic uilogic = new UILogic(new HazenWilliamsCalculator());

List<IResults> ResultsList = uilogic.GetInputsAndCalculate();

OutputHelper.PrintResults(ResultsList);
