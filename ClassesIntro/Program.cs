
Airplane planeOne = new Airplane("Jeff", "Delta");

Airplane planeTwo = new Airplane("Trevor", "American Airlines");

// planeOne.Name = "Jeff";
// planeOne.NumEngines = 4;

if(null != planeOne.Name) {
    Console.WriteLine($"planeOne name: {planeOne.Name}");
} else {
    Console.WriteLine($"planeOne name: null");
}

Console.WriteLine($"planeOne airline: {planeOne.Airline}");

planeOne.Fly();
