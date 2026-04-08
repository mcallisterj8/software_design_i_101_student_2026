namespace GenericsExamples.Models;

public class SmartBox<T> where T : Phone {
    public required string Name { get; set; }
    public required T Item;
    public List<T> ItemList { get; set; } = new List<T> { };

    public override string ToString() {
        // Notice that we can call "Brand" property because T : Phone.
        string output = $"{this.Name} Item: {this.Item.Brand}\n{this.Name} ItemList:\n";

        foreach (T elem in this.ItemList) {
            // Can also call the Model property because T : Phone.
            output += $"{elem.Model}\n";
        }

        return output;
    }
}