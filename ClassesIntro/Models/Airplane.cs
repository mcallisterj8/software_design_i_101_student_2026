using System.Reflection.Metadata.Ecma335;

public class Airplane {
    public string? Name { get; set; } // default value for string => null
    public string? Airline { get; set; }
    public int NumEngines { get; set; } // default for int => 0 

    public Airplane(){}
    
    public Airplane(string name, int numEngines){
        this.Name = name;
        this.NumEngines = numEngines;
    }
     public Airplane(string name, int numEngines, string airline){
        this.Name = name;
        this.NumEngines = numEngines;
    }

    public Airplane( int numEngines, string name){
        this.Name = name;
        this.NumEngines = numEngines;
    }

    public Airplane( string name, string airline){
        this.Name = name;
        this.Airline = airline;
    }

    

    private void DeployAirbags() {
        Console.WriteLine($"Deploying the airbags!");
    }

    public void Fly() {
        // return $"{this.Name} is flying!";

        bool result = this.SystemCheck();
        if(!result){
            Console.WriteLine("Cannot fly.");
            return;
        }

        Console.WriteLine($"{this.Name} is flying!");
    }

    private bool SystemCheck() {
        bool hasProblem = false; // For sake of example
        Console.WriteLine($"Checking system...");
        if(hasProblem) {
            return false;
        }
        Console.WriteLine($"Check complete.");

        return true;
    }
    
}