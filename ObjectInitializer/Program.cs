// Console.WriteLine("\n============================================================");
// Console.WriteLine("1. Using the Constructor");
// Console.WriteLine("============================================================");

Airplane planeOne = new Airplane("Boeing 737", 35000, 2, 5000m);

// Console.WriteLine($"Name: {planeOne.Name}");
// Console.WriteLine($"Max Altitude: {planeOne.MaxAltitude}");
// Console.WriteLine($"Engines: {planeOne.NumEngines}");
// Console.WriteLine($"Fuel Level: {planeOne.FuelLevel}");

Console.WriteLine("\n============================================================");
Console.WriteLine("2. Object Initializer Syntax (Flexible Property Assignment)");
Console.WriteLine("============================================================");

Airplane planeTwo = new Airplane
{
    Name = "Airbus A320",
    NumEngines = 2
    // MaxAltitude and FuelLevel are not set here
};

// Console.WriteLine($"Name: {planeTwo.Name}");
// Console.WriteLine($"Max Altitude: {planeTwo.MaxAltitude}"); // default 0
// Console.WriteLine($"Engines: {planeTwo.NumEngines}");

// Will call the ToString() method
Console.WriteLine(planeTwo);
Console.WriteLine("\n\n");