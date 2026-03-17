public class Automobile : Vehicle {
    public string LicensePlate { get; set; } = "Default";
    public int SeatingCapacity { get; set; } = 2;
    protected bool IsElectric { get; set; }

    public Automobile(string licensePlate, int seatingCapcity, bool isElectric) {
        this.LicensePlate = licensePlate;
        this.SeatingCapacity = seatingCapcity;
        this.IsElectric = isElectric;
    }
}