Console.WriteLine("============================================================");
Console.WriteLine("EXAMPLE 1: Divide By Zero");
Console.WriteLine("============================================================");

try {
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator;

    Console.WriteLine($"Result: {result}");
} catch (DivideByZeroException ex) {
    string errorMessage
        = $"A divide by zero exception occurred. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new DivideByZeroException(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
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
    string errorMessage = $"A format exception occurred. The input could not be converted into an integer. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new FormatException(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 3: Index Out Of Range");
Console.WriteLine("============================================================");

try {
    int[] numbers = { 10, 20, 30 };
    Console.WriteLine($"Item at index 5: {numbers[5]}");
} catch (IndexOutOfRangeException ex) {
    string errorMessage = $"An index out of range exception occurred. The program tried to access an index that does not exist. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new IndexOutOfRangeException(errorMessage);

    /*
        Below is another option to throw an exception. When the below example i
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 4: Multiple Catch Blocks");
Console.WriteLine("============================================================");

/*
    These catch statements are checked top-down, with only one ever firing.
    The first one to match will run.

    The manner in which these are checked is similar to an else-if chain.
*/

try {
    string? maybeNumber = null;
    // string? maybeNumber = "abc"; // This will cause FormatException to be thrown.

    Console.WriteLine($"Length: {maybeNumber.Length}");

    int number = int.Parse(maybeNumber);
    Console.WriteLine($"Parsed number: {number}");
} catch (NullReferenceException ex) {
    string errorMessage = $"A null reference exception occurred. The program tried to use an object that was null. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new NullReferenceException(errorMessage)
    // 
    /*
        Below is another option to throw an exception. When the below example i
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
     */
    ;
    // throw;
} catch (FormatException ex) {
    string errorMessage = $"A format exception occurred. The input could not be converted into an integer. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new FormatException(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
} catch (Exception ex) {
    string errorMessage = $"A general exception occurred. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new Exception(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 5: Finally Block");
Console.WriteLine("============================================================");

try {
    Console.WriteLine("Inside try block.");
    int[] values = { 1, 2, 3 };
    Console.WriteLine(values[10]);
} catch (Exception ex) {
    string errorMessage = $"An exception was caught. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new Exception(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    throw;
} finally {
    Console.WriteLine("\nThe finally block always runs.\n");
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 6: Throwing An Argument Exception");
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
    string errorMessage = $"An argument exception occurred. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new ArgumentException(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
}


Console.WriteLine("\n============================================================");
Console.WriteLine("EXAMPLE 7: Program Continues After Catch");
Console.WriteLine("============================================================");

try {
    int number = int.Parse("hello");
    Console.WriteLine(number);
} catch (FormatException ex) {
    string errorMessage = $"A format exception occurred. Message: {ex.Message}";

    Console.WriteLine(errorMessage);
    /*
        After throwing an exception, the program will terminate. Below is more
        of what you will see in production code. This is commented out here
        so that the program will run through all examples. Uncomment the below
        to see the behavior of throwing an exception.
    */
    // throw new FormatException(errorMessage);

    /*
        Below is another option to throw an exception. When the below example is
        used, the original exception object is preserved; whereas with the first
        example where we call the "new" keyword, we are creating a new exception
        object instance.
    */
    // throw;
}

Console.WriteLine("The program did not crash.");
Console.WriteLine("Execution continued after the catch block.");