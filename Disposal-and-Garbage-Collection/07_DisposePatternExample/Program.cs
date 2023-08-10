using System;

namespace Finalizers
{
    class Program
    {
        static void Run()
        {
            using PureManagedClass mc = new PureManagedClass();

            mc.StartWriting();
        }

        static void Main()
        {
            Run();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}