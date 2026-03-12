
// int[] numberArr = new int[4];

// numberArr[0] = 3;
// numberArr[1] = 42;
// numberArr[2] = 48;
// numberArr[3] = 80;
// numberArr[4] = 12;

// for(int i = 0; i < numberArr.Length; i++) {
//     Console.WriteLine($"numberArr[{i}] = {numberArr[i]}");
// }

Console.WriteLine("================= Count & Capacity ===========");
List<int> numberList = new List<int>();
numberList.Add(8);
numberList.Add(12);
numberList.Add(10);
numberList.Add(16);
numberList.Add(20);

Console.WriteLine($"Count: {numberList.Count}"); // Equivalent of Length for arrays
Console.WriteLine($"Capacity: {numberList.Capacity}");


Console.WriteLine("=======================================");

Console.WriteLine("================= Count & Capacity ===========");
// List<string> fruits = new List<string>{"apple", "banana", "cherry"};
List<string> fruits = ["apple", "banana", "cherry"];

foreach(string fruit in fruits) {
    Console.WriteLine(fruit);
}

// Methods are PascalCase
bool result = fruits.Remove("banana");

Console.WriteLine("\nAfter editing list:");
foreach(string fruit in fruits) {
    Console.WriteLine(fruit);
}

Console.WriteLine($"result: {result}");

Console.WriteLine("=======================================");

Console.WriteLine("================= Removing with Predicate ===========");
List<decimal> decimalList = new List<decimal>{12.75m, 3.4m, 0.99m, 12.75m, 7m};

Console.WriteLine("Before Removal");
foreach(decimal number in decimalList) {
    Console.WriteLine(number);
}

decimalList.RemoveAll(num => num < 10);

Console.WriteLine("\nAfter Removal");
foreach(decimal number in decimalList) {
    Console.WriteLine(number);
}

// Console.WriteLine($"0.1 + 0.2 = {0.1 + 0.2}");
// Console.WriteLine($"0.1m + 0.2m = {0.1m + 0.2m}");


Console.WriteLine("=======================================");