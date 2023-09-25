using System.Globalization;
using PLConsoleApp.InputHelpers;

using PressureLossCalculations.Models;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

List<IResults> ResultsList = InputHelper.GetPipesInputs();

OutputHelper.PrintResults(ResultsList);
