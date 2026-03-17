Console.WriteLine("\n============================================================");
Console.WriteLine("1. Creating a base class object");
Console.WriteLine("============================================================");

Vehicle genericVehicle = new Vehicle();

Console.WriteLine($"Name: {genericVehicle.Name}");
Console.WriteLine($"Model Year: {genericVehicle.ModelYear}");
genericVehicle.Drive();
genericVehicle.Stop();

