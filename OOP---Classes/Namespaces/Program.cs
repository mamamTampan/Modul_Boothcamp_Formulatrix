using CalculatorLibrary;
using CalculatorLibrary.NotACalculator;
class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator.Add(1, 2));
        Console.WriteLine(CalculatorNotACalculator.Add(1, 2));
    }
}
