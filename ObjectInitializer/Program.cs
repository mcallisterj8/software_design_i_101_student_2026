Console.WriteLine("\n============================================================");
Console.WriteLine("1. Using the Constructor");
Console.WriteLine("============================================================");

Airplane plane1 = new Airplane("Boeing 737", 35000, 2, 5000m);

Console.WriteLine($"Name: {plane1.Name}");
Console.WriteLine($"Max Altitude: {plane1.MaxAltitude}");
Console.WriteLine($"Engines: {plane1.NumEngines}");
Console.WriteLine($"Fuel Level: {plane1.FuelLevel}");

Console.WriteLine("\n============================================================");
Console.WriteLine("2. Object Initializer Syntax (Flexible Property Assignment)");
Console.WriteLine("============================================================");

Airplane plane2 = new Airplane
{
    Name = "Airbus A320",
    NumEngines = 2
    // MaxAltitude and FuelLevel are not set here
};

Console.WriteLine($"Name: {plane2.Name}");
Console.WriteLine($"Max Altitude: {plane2.MaxAltitude}"); // default 0
Console.WriteLine($"Engines: {plane2.NumEngines}");

// Will call the ToString() method
// Console.WriteLine(plane2);