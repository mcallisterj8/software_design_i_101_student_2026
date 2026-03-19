Console.WriteLine("\n================= Compile Time & Runtime Types ================\n");
Vehicle vehicleOne = new Vehicle();
Airplane airplaneOne = new Airplane("Delta", 35000, 2);
Automobile carOne = new Automobile("ABC123", 5, false);
Boat boatOne = new Boat(30.5, true, "Yacht");

Vehicle mysteryBox = new Airplane("Delta", 35000, 2);
mysteryBox.Drive();

if(mysteryBox is Airplane) {
    ((Airplane)mysteryBox).DeployLandingGear();
} else {
    Console.WriteLine("Airplane is not in mysterBox");
}

mysteryBox = new Automobile("ABC123", 5, false);
mysteryBox.Drive();

Console.WriteLine("==================================");
List<Vehicle> vehicles = new List<Vehicle> {
    vehicleOne, 
    airplaneOne,
    carOne,
    boatOne
};

foreach(Vehicle elem in vehicles) {
    elem.Drive();
}

