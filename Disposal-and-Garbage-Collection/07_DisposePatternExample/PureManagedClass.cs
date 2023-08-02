using System;
using System.IO;

namespace Finalizers
{
    public sealed class PureManagedClass : IDisposable
    {
        private StreamWriter _writer;

        public void StartWriting()
        {
            _writer = new StreamWriter("output.txt");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing");

            _writer?.Dispose();

            GC.SuppressFinalize(this);
        }

        ~PureManagedClass()
        {
            Console.WriteLine("Finalizing");
        }

    }
}