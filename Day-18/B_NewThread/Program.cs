using System;
using System.Threading;

static class Program
{
    static void Main()
    {
        Thread newThread = new Thread(PrintNumbers);
        newThread.Start();
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
