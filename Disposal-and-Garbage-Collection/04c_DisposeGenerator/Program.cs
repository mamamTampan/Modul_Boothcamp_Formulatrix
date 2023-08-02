using System;
using System.Diagnostics;
namespace GarbageCollectionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			for (int i = 0; i <= 1000000; i++)
			{
				ObjectGenerator();

			}
			stopwatch.Stop();
			Console.WriteLine("Elapsed time: " + stopwatch.Elapsed);

			Console.Read();
		}
		static void ObjectGenerator() 
		{
				MyClass1 obj1 = new MyClass1();
				MyClass2 obj2 = new MyClass2();
				MyClass3 obj3 = new MyClass3();
				obj1.Dispose();
				obj2.Dispose();
				obj3.Dispose();
		}
	}

	public class MyClass1 : IDisposable
	{
		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					
				}
				disposedValue = true;
			}
		}
		~MyClass1()
		{
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			 GC.SuppressFinalize(this);
		}

	}

	public class MyClass2 : IDisposable
	{
		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
				}
				disposedValue = true;
			}
		}
		~MyClass2()
		{
			Dispose(false);
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

	}

	public class MyClass3 : IDisposable
	{
		private bool disposedValue = false; 

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
				}
				
				disposedValue = true;
			}
		}
		
		~MyClass3()
		{
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}