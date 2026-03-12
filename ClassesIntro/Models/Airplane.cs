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

    
}