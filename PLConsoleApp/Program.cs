using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using PLConsoleApp;
using PLConsoleApp.InputHelpers;
using PLConsoleApp.UILogic;
using PressureLossCalculations.Models;
using PressureLossCalculations.Services;
using DataAccess.DbAccess;
using DataAccess.Models;
using System.Collections.Generic;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;



var container = Startup.ConfigureService();

var uilogic = container.GetRequiredService<ConsoleUILogic>();

List<IResults> ResultsList = uilogic.GetInputsAndCalculate();

OutputHelper.PrintResults(ResultsList);
