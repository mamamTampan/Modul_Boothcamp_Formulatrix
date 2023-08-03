static class Program
{
    static void Main(string[] args)
    {
        // Variables used by multiple threads
        int counter = 0;
        bool isRunning = true;

        // Thread 1 increments counter
        Thread thread1 = new Thread(() =>
        {
            while (isRunning)
            {
                counter++;
                Console.WriteLine($"Thread 1: counter = {counter}");
            }
        });

        // Thread 2 sets isRunning to false after 5 seconds
        Thread thread2 = new Thread(() =>
        {
            Thread.Sleep(5000);
            isRunning = false;
            Console.WriteLine("Thread 2: isRunning = false");
        });

        // Start both threads
        thread1.Start();
        thread2.Start();
    }
}
