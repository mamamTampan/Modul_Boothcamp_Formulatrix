using System;

namespace CallbackExample
{
    public delegate void TaskComplete();

    class Program
    {
        static void Main(string[] args)
        {
            TaskComplete callback = OnTaskCompleted;
            PerformTask(callback);
        }

        static void PerformTask(TaskComplete callback)
        {
            Console.WriteLine("Menjalankan tugas...");
            callback();
        }

        static void OnTaskCompleted()
        {
            Console.WriteLine("Tugas selesai!");
        }
    }
}