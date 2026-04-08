public class Phone {
    public string Brand { get; set; } = "Default Brand";
    public string Model { get; set; } = "Default Model";

    public virtual void UseAssistant(string givenCommand) {
        Console.WriteLine("Phone UseAssistant() method.");
    }

    public virtual void BrowseInternet() {
        Console.WriteLine("Phone is browsing the internet.");
    }
}