using System.Globalization;
using PressureLossCalculations;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

List<IResults> ResultsList = new List<IResults>();

while (true)
{
    InputData inputData = GetAllInputs();
    IResults results = new ResultsHazenWilliams(inputData);
    ResultsList.Add(results);

    Console.WriteLine("Do you want to add another pipe? (y/n)");
    string answer = Console.ReadLine();
    while (answer != "y" && answer !="n")
    {
        Console.WriteLine("Unacceptable answer. Do you want to add another pipe? (y/n)");
        answer = Console.ReadLine();
    }
    if (answer == "n") break;
}






Console.Write("Tratti:".PadRight(20)); Console.Write("PdC lin.".PadRight(20)); Console.Write("PdC loc.".PadRight(20)); Console.Write("PdC tot.".PadRight(20)); Console.WriteLine();

int i = 1;
foreach (IResults results in ResultsList)
{

    Console.Write(i.ToString().PadRight(20));
    Console.Write(results.FrictionalPressureLoss.ToString("#.##").PadRight(20));
    Console.Write(results.LocalPressureLoss.ToString("#.##").PadRight(20));
    Console.Write(results.TotalPressureLoss.ToString("#.##").PadRight(20));
    Console.WriteLine();
    i++;
}





double RetrieveDoubleValue(string message)
{
    Console.WriteLine(message);
    string? inputValue = Console.ReadLine();
    bool validity = double.TryParse(inputValue, out double value);
    if (validity && value >= 0)
    {
        return value;
    }
    else
    {
        Console.WriteLine("Invalid format, try again");
        return RetrieveDoubleValue(message);
    }
}

int RetrieveIntValue(string message)
{
    Console.WriteLine(message);
    string? inputValue = Console.ReadLine();
    bool validity = int.TryParse(inputValue, out int value);
    if (validity && value >= 0)
    {
        return value;
    }
    else
    {
        Console.WriteLine("Invalid format, try again");
        return RetrieveIntValue(message);
    }
}

InputData GetAllInputs()
{
    double pipeLenght = RetrieveDoubleValue("Pipe lenght (m):");
    double pipeDiameter = RetrieveDoubleValue("Pipe internal diameter (mm):");
    double waterFlowRate = RetrieveDoubleValue("Water flow rate (l/s):");
    double pipeSurfaceFactor = RetrieveDoubleValue("Pipe Surface Factor:");
    int numberOf90DegCurves = RetrieveIntValue("Number Of 90° Curves:");
    int numberOf45DegCurves = RetrieveIntValue("Number Of 45° Curves:");
    int numberOfTJunctions = RetrieveIntValue("Number Of T Junctions:");

    InputData inputData = new InputData
        (pipeLenght, pipeDiameter, waterFlowRate, pipeSurfaceFactor, numberOf90DegCurves, numberOf45DegCurves, numberOfTJunctions);
    return inputData;
}