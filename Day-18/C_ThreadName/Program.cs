using System;
using System.Threading;

class Program
{
	static void Main()
	{
		// Create a new thread
		Thread thread = new Thread(DoWork);
		Thread secondThread = new Thread(DoWork);

		// Set some properties
		thread.Name = "Worker Thread";
		secondThread.Name = "Second Worker Thread";

		// Start the thread
		thread.Start();
		secondThread.Start();

		Console.WriteLine("Main thread exiting.");
	}

	static void DoWork()
	{
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		Thread.Sleep(2000);
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished.");
	}
}
