using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = new Task(() => Console.WriteLine("Hello, Task!"));
        task.Start();

        task.Wait(); // Wait for the task to complete
    }
}
