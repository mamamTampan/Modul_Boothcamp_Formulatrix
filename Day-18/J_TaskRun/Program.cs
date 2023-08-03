using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task = new Task(() => Console.WriteLine("Hello, Task Start!"));
		task.Start();
		task.Wait(); // Wait for the task to complete

		Task task1 = Task.Run(() => Console.WriteLine("Hello, Task.Run!"));
		task1.Wait(); // Wait for the task to complete
		
		Task.Run(() => Console.WriteLine("Hello, Task Run Immediately!")); // Same as above
	}
}
