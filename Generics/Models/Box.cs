namespace GenericsExamples.Models;

public class Box<T> {
    public required string Name { get; set; }
    public required T Item { get; set; }
    public List<T> ItemList { get; set; } = new List<T> { };

    public override string ToString() {
        // Can only call methods on elements that all possible things of type T have.
        string output = $"{this.Name} Item: {this.Item}\n{this.Name} ItemList:\n";

        foreach (T elem in this.ItemList) {
            output += $"{elem}\n";
        }

        return output;
    }

}