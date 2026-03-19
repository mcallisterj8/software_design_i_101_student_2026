public class Automobile : Vehicle {
    public string LicensePlate { get; set; } = "Default";
    public int SeatingCapacity { get; set; } = 2;
    protected bool IsElectric { get; set; }

    public Automobile(string licensePlate, int seatingCapcity, bool isElectric) {                
        Console.WriteLine("Automobile constructor!");
        this.LicensePlate = licensePlate;
        this.SeatingCapacity = seatingCapcity;
        this.IsElectric = isElectric;              
    }

    public override void Drive() {
        Console.WriteLine("Automobile is driving!");
    }

    public override void Stop() {
        Console.WriteLine("Automobile has parked!");
    }

    public virtual void TestMethod() {
        Console.WriteLine("Automobile Test Method!");
    }

    public void Honk() {
        Console.WriteLine("Honking the horn");
    }

    protected void BatteryCheck() {
        if(this.IsElectric) {
            Console.WriteLine("Checking battery level.");
        }
    }
}