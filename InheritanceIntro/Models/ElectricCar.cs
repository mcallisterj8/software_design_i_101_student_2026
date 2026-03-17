public class ElectricCar : Automobile {
    public int BatteryCapacity { get; set; }

    public ElectricCar(string licensePlate, int seatingCapcity, int batteryCapacity) 
        : base(licensePlate, seatingCapcity, true) {
            Console.WriteLine("ElectricCar constructor!");
            this.BatteryCapacity = batteryCapacity;
    }

    public void ChargeBattery() {
        Console.WriteLine("Charging the battery");
    }

    public override void TestMethod() {
        Console.WriteLine("ElectricCar Test Method");
    }

    public override void Drive() {
        Console.WriteLine("Electric car is driving efficiently");
    }

}