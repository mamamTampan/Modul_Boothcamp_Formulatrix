using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() => Console.WriteLine("Hello from Task!"));
        task.Wait();

        Console.WriteLine($"IsCompleted: {task.IsCompleted}");
        Console.WriteLine($"IsFaulted: {task.IsFaulted}");
        Console.WriteLine($"IsCanceled: {task.IsCanceled}");
    }
}
