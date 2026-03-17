Console.WriteLine("\n============================================================");
Console.WriteLine("1. Creating a base class object");
Console.WriteLine("============================================================");

Vehicle genericVehicle = new Vehicle();

Console.WriteLine($"Name: {genericVehicle.Name}");
Console.WriteLine($"Model Year: {genericVehicle.ModelYear}");
genericVehicle.Drive();
genericVehicle.Stop();

Console.WriteLine("\n============================================================");
Console.WriteLine("2. Creating an Automobile object");
Console.WriteLine("============================================================");

Automobile car = new Automobile("ABC-123", 5, false);
car.Name = "Family Sedan"; // Inherited from Vehicle
car.ModelYear = 2022; // Inherited from Vehicle
car.Drive();

Console.WriteLine("\n============================================================");
Console.WriteLine("3. Creating an ElectricCar object (Multi-Level Inheritance)");
Console.WriteLine("============================================================");

ElectricCar tesla = new ElectricCar("EV-2026", 5, 100);

tesla.Drive();
tesla.ChargeBattery();
tesla.Honk();
tesla.Stop();
tesla.TestMethod();


