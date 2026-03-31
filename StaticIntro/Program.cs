Console.WriteLine("============================================================");
Console.WriteLine("Static Property Example");
Console.WriteLine("============================================================");

Console.WriteLine($"Company: {iPhone.Company}");
Console.WriteLine($"Total phones created so far: {iPhone.TotalPhonesCreated}");

Console.WriteLine("\nCreating phoneOne...");
iPhone phoneOne = new iPhone {
    Name = "Tom's Phone",
    Model = "iPhone 15",
    Color = "Black",
    BatteryPercentage = 100
};

Console.WriteLine($"Company: {iPhone.Company}");
Console.WriteLine($"Total phones created so far: {iPhone.TotalPhonesCreated}");
Console.WriteLine($"phoneOne Name: {phoneOne.Name}");
Console.WriteLine($"phoneOne Model: {phoneOne.Model}");
Console.WriteLine($"phoneOne Color: {phoneOne.Color}");
phoneOne.CompanyName();
Console.WriteLine("=================");
iPhone.ShowCompanyInfo();


Console.WriteLine("\n\n\n\n");

// Console.WriteLine("\nCreating phoneTwo...");
// iPhone phoneTwo = new iPhone {
//     Name = "Work Phone",
//     Model = "iPhone 15 Pro",
//     Color = "Silver",
//     BatteryPercentage = 85
// };

// Console.WriteLine($"Total phones created so far: {iPhone.TotalPhonesCreated}");
// Console.WriteLine($"phoneTwo Name: {phoneTwo.Name}");
// Console.WriteLine($"phoneTwo Model: {phoneTwo.Model}");
// Console.WriteLine($"phoneTwo Color: {phoneTwo.Color}");
// phoneTwo.ShowBattery();

// Console.WriteLine("\nCreating phoneThree...");
// iPhone phoneThree = new iPhone {
//     Name = "Backup Phone",
//     Model = "iPhone SE",
//     Color = "Red",
//     BatteryPercentage = 60
// };

// Console.WriteLine($"Total phones created so far: {iPhone.TotalPhonesCreated}");
// Console.WriteLine($"phoneThree Name: {phoneThree.Name}");
// Console.WriteLine($"phoneThree Model: {phoneThree.Model}");
// Console.WriteLine($"phoneThree Color: {phoneThree.Color}");
// phoneThree.ShowBattery();

// Console.WriteLine($"\nCompany: {iPhone.Company}");