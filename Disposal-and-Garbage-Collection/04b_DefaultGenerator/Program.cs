using System;
using System.Diagnostics;

namespace StopwatchDemo
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
		}
	}

	public class MyClass1
	{
	}

	public class MyClass2
	{
	}

	public class MyClass3
	{
	}
}
