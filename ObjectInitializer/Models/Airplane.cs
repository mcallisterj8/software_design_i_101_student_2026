public class Airplane {
    public string Name { get; set; }
    public int MaxAltitude { get; private set; }
    public int NumEngines { get; set; }
    public decimal FuelLevel { get; private set; }

    public Airplane() { }

    public Airplane(string name, int maxAltitude, int numEngines, decimal initialFuel) {
        this.Name = name;
        this.MaxAltitude = maxAltitude;
        this.NumEngines = numEngines;
        this.FuelLevel = initialFuel;
    }

    public void Fly(int altitude) {
        if (altitude > this.MaxAltitude) {
            Console.WriteLine($"{this.Name} cannot fly at {altitude} feet! Max is {this.MaxAltitude} feet.");

        } else if (this.FuelLevel <= 0) {
            Console.WriteLine($"{this.Name} cannot take off! No fuel.");

        } else {
            Console.WriteLine($"{this.Name} is flying at {altitude} feet.");
            this.FuelLevel -= altitude * 0.001m; // Simulate fuel consumption
        }
    }

    public void Stop() {
        this.DeployLandingGear();
        Console.WriteLine($"{this.Name} is landing.");
    }

    public void DeployLandingGear() {
        Console.WriteLine("Deploying landing gear...");
    }

    protected void EngineCheck() {
        Console.WriteLine($"Checking {this.NumEngines} engines...");
    }

    public decimal Refuel(decimal amount) {
        if (amount <= 0) {
            Console.WriteLine("Refuel amount must be positive!");

            return this.FuelLevel;
        }

        this.FuelLevel += amount;

        return this.FuelLevel;
    }

    private void EmergencyLanding() {
        Console.WriteLine("Performing emergency landing");
        this.DeployLandingGear();
    }

    public override string ToString() {
        return $"Airplane Details:\n" +
               $"  Name: {this.Name}\n" +
               $"  Max Altitude: {this.MaxAltitude} ft\n" +
               $"  Number of Engines: {this.NumEngines}\n" +
               $"  Fuel Level: {this.FuelLevel} units";
    }

}