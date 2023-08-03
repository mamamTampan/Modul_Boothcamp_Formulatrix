using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create a new thread and assign the PrintNumbers method to it.
        Thread newThread = new Thread(PrintNumbers);

        // Start the thread.
        newThread.Start();

        // Sleep the main thread for 2 seconds.
        Thread.Sleep(2000);

        // Check if the newThread is alive.
        Console.WriteLine($"Is newThread alive? {newThread.IsAlive}");

        // Set newThread priority.
        newThread.Priority = ThreadPriority.Highest;

        // Set newThread as a background thread.
        newThread.IsBackground = true;

        // Join the newThread to wait for it to finish before continuing the main thread.
        newThread.Join();

        Console.WriteLine("Main thread continues.");
        
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(1000);
        }
    }
}
