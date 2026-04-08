iPhone iphoneA = new iPhone { Name = "apple" };
iPhone iphoneB = new iPhone { Name = "berry" };
iPhone iphoneC = new iPhone { Name = "cherry" };
iPhone iphoneD = new iPhone { Name = "kiwi" };

Android androidA = new Android { Name = "date" };
Android androidB = new Android { Name = "elderberry" };
Android androidC = new Android { Name = "kiwi" };

Toolbox toolbox = new Toolbox { Name = "ToolboxA" };

// Can compare two distinct types, or can use the same type
bool result = toolbox.ComparePhoneNames(iphoneD, androidC);

Console.WriteLine("============================================================");
Console.WriteLine("1. Comparing Phone Names with Generics");
Console.WriteLine("============================================================");
Console.WriteLine($"iphoneD and androidC have the same name: {result}");

bool secondComparison = toolbox.ComparePhoneNames(iphoneA, iphoneB);
Console.WriteLine($"iphoneA and iphoneB have the same name: {secondComparison}");

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("2. Echo<T> Example");
Console.WriteLine("============================================================");

string echoedWord = toolbox.Echo("Hello Generics");
Console.WriteLine($"Returned from Echo<string>: {echoedWord}");

int echoedNumber = toolbox.Echo(42);
Console.WriteLine($"Returned from Echo<int>: {echoedNumber}");

iPhone echoedPhone = toolbox.Echo(iphoneA);
Console.WriteLine($"Returned from Echo<iPhone>: {echoedPhone.Name}");

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("3. Swap<T> Example with Strings");
Console.WriteLine("============================================================");

SwapResult<string> swappedFruits = toolbox.Swap("apple", "banana");
Console.WriteLine($"First: {swappedFruits.First}");
Console.WriteLine($"Second: {swappedFruits.Second}");

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("4. Swap<T> Example with iPhone Objects");
Console.WriteLine("============================================================");

SwapResult<iPhone> swappedPhones = toolbox.Swap(iphoneA, iphoneB);
Console.WriteLine($"First phone after swap: {swappedPhones.First.Name}");
Console.WriteLine($"Second phone after swap: {swappedPhones.Second.Name}");

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("5. AddNumbers<T> Example");
Console.WriteLine("============================================================");

int wholeNumberSum = toolbox.AddNumbers(10, 25);
Console.WriteLine($"AddNumbers<int>(10, 25): {wholeNumberSum}");

decimal decimalSum = toolbox.AddNumbers(4.5m, 2.25m);
Console.WriteLine($"AddNumbers<decimal>(4.5m, 2.25m): {decimalSum}");

double doubleSum = toolbox.AddNumbers(1.2, 3.4);
Console.WriteLine($"AddNumbers<double>(1.2, 3.4): {doubleSum}");

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("6. Display<T> Example");
Console.WriteLine("============================================================");

toolbox.Display("This is a string.");
toolbox.Display(999);
toolbox.Display(iphoneC);
toolbox.Display(androidA);

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("7. Why Generics Matter");
Console.WriteLine("============================================================");
Console.WriteLine("Echo<T> works with many data types using one method.");
Console.WriteLine("Swap<T> can swap strings, numbers, or objects.");
Console.WriteLine("AddNumbers<T> works with numeric types because of its constraint.");
Console.WriteLine("ComparePhoneNames<T1, T2> only allows types that inherit from Phone.");