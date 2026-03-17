public class Vehicle {
    public string Name { get; set; } = "Default Name";
    public int ModelYear { get; set; } = 2026;
    public string Manufacturer { get; set; } = "Default Manufacturer";

    public Vehicle() {
        Console.WriteLine("Vehicle constructor!");
    }

    public virtual void Drive() {
        Console.WriteLine("Vehicle is driving");
    }

    public virtual void Stop() {
        Console.WriteLine("Vehicle is stopping");
    }

    private void MainenanceCheck() {
        Console.WriteLine("Performing maintenance check");
    }

    protected void DisplayManufacturer() {
        Console.WriteLine($"Manufacturer: {this.Manufacturer}");
    }
}