using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Returning values from tasks using Task<TResult>
        Task<int> task = Task.Run(() => Add(3, 4));

        int result = task.Result;
        Console.WriteLine($"Result: {result}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
