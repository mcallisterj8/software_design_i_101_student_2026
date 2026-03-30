public class iPhone
{
    // Not allowing for set method. Optionally could have that though.
    public static string Company { get; } = "Apple";
    public string Name { get; set; } = "Default";
    public string Model { get; set; }
    public string Color { get; set; }
    public int BatteryPercentage { get; set; }

    public static int TotalPhonesCreated { get; private set; } = 0;

    public iPhone()
    {
        TotalPhonesCreated++;
    }

    public void CompanyName()
    {
        Console.WriteLine($"Company Name for {this.Name}: {iPhone.Company}");
    }

    public static void ShowCompanyInfo()
    {
        Console.WriteLine($"Company: {iPhone.Company}");
        Console.WriteLine("iPhones are smartphones made by Apple.");
    }

    public void MakeCall(string phoneNumber)
    {
        Console.WriteLine($"{this.Model} is calling {phoneNumber}...");
        this.BatteryPercentage -= 1;
    }

    public void Charge()
    {
        this.BatteryPercentage = 100;
        Console.WriteLine($"{this.Model} is now fully charged.");
    }

    public void ShowBattery()
    {
        Console.WriteLine($"{this.Model} battery: {this.BatteryPercentage}%");
    }
}