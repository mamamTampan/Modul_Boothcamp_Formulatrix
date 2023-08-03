using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Run multiple tasks concurrently
        Task<int>[] tasks = numbers.Select(n => MultiplyByTwoAsync(n)).ToArray();

        // Wait for all tasks to complete and get the results
        int[] results = await Task.WhenAll(tasks);

        // Print the results
        Console.WriteLine(string.Join(", ", results));
    }

    static async Task<int> MultiplyByTwoAsync(int number)
    {
        await Task.Delay(500); // Simulate an asynchronous operation
        return number * 2;
    }
}
