using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        foreach (int number in GetEvenNumbers(1, 10)) //its a foreach (Enumerable)
        {
            Console.WriteLine(number);
        }
    }
    
    public static IEnumerable<int> GetEvenNumbers(int start, int end) //its a IEnumerable (Iterator)
    {
        for (int i = start; i <= end; i++)
        {
                yield return i;
        }
    }
}
