Console.WriteLine("============================================================");
Console.WriteLine("EXAMPLE 1: Divide By Zero");
Console.WriteLine("============================================================");

try {
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator;

    Console.WriteLine($"Result: {result}");
} catch (DivideByZeroException ex) {
    Console.WriteLine("A divide by zero exception occurred.");
    Console.WriteLine($"Message: {ex.Message}");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 2: Parsing Invalid Input");
Console.WriteLine("============================================================");

try {
    // Imagine we received this from the user.
    string userInput = "abc";
    // Attempt to parse integer from result, which will fail in this example.
    int parsedNumber = int.Parse(userInput);

    Console.WriteLine($"Parsed number: {parsedNumber}");
} catch (FormatException ex) {
    Console.WriteLine("A format exception occurred.");
    Console.WriteLine("The input could not be converted into an integer.");
    Console.WriteLine($"Message: {ex.Message}");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 3: Index Out Of Range");
Console.WriteLine("============================================================");

try {
    int[] numbers = { 10, 20, 30 };
    Console.WriteLine($"Item at index 5: {numbers[5]}");
} catch (IndexOutOfRangeException ex) {
    Console.WriteLine("An index out of range exception occurred.");
    Console.WriteLine("The program tried to access an index that does not exist.");
    Console.WriteLine($"Message: {ex.Message}");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 4: Multiple Catch Blocks");
Console.WriteLine("============================================================");

/*
    These catch statements are checked top-down, with only one ever firing.
    The first one to be caught will throw.

    The manner in which these are checked is the same as would be expected
    for an else-if chain.
*/

try {
    string? maybeNumber = null;
    // string? maybeNumber = "abc"; // This will cause FormatException to be thrown.

    Console.WriteLine($"Length: {maybeNumber.Length}");

    int number = int.Parse(maybeNumber);
    Console.WriteLine($"Parsed number: {number}");
} catch (NullReferenceException ex) {
    Console.WriteLine("A null reference exception occurred.");
    Console.WriteLine("The program tried to use an object that was null.");
    Console.WriteLine($"Message: {ex.Message}");
} catch (FormatException ex) {
    Console.WriteLine("A format exception occurred.");
    Console.WriteLine($"Message: {ex.Message}");
} catch (Exception ex) {
    Console.WriteLine("A general exception occurred.");
    Console.WriteLine($"Message: {ex.Message}");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 5: Finally Block");
Console.WriteLine("============================================================");

try {
    Console.WriteLine("Inside try block.");
    int[] values = { 1, 2, 3 };
    Console.WriteLine(values[10]);
} catch (Exception ex) {
    Console.WriteLine("An exception was caught.");
    Console.WriteLine($"Message: {ex.Message}");
} finally {
    Console.WriteLine("The finally block always runs.");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 6: Throwing An Arugment Exception");
Console.WriteLine("============================================================");

try {
    int age = -5;

    if (age < 0) {
        /* 
            The exception that is thrown when one of the arguments provided to a method is not valid.
            Using here for an invalid conditional though.
        */
        throw new ArgumentException("Age cannot be negative.");
    }

    Console.WriteLine($"Age: {age}");
} catch (ArgumentException ex) {
    Console.WriteLine("An argument exception occurred.");
    Console.WriteLine($"Message: {ex.Message}");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 7: Program Continues After Catch");
Console.WriteLine("============================================================");

try {
    int number = int.Parse("hello");
    Console.WriteLine(number);
} catch (FormatException ex) {
    Console.WriteLine("Caught a format exception.");
    Console.WriteLine($"Message: {ex.Message}");
}

Console.WriteLine("The program did not crash.");
Console.WriteLine("Execution continued after the catch block.");