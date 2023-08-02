using System;

class Program
{
    static void Main()
    {
        // Formatting example
        double number = 1234.5678;

        // Display the number formatted as currency with two decimal places
        Console.WriteLine("Currency format: {0:C2}", number);

        // Display the number formatted with a thousands separator
        Console.WriteLine("Number format with separator: {0:N}", number);

        // Display the number formatted with a custom format string to three decimal places
        Console.WriteLine("Number format with custom string: {0:0.000}", number);

        // Parsing example
        string input = "1234.56";

        // Parse the input string as a double
        double result = double.Parse(input);

        // Display the parsed result formatted as currency with two decimal places
        Console.WriteLine("Parsed result as currency: {0:C2}", result);

        // Parse the input string as an integer
        double result2 = double.Parse(input);

        // Display the parsed result formatted as a number with a thousands separator
        Console.WriteLine("Parsed result as number: {0:N0}", result2);
    }
}
