using System;
using System.Threading;

class Program
{
	static void Main()
	{
		//Create a new thread
		Thread t0 = new Thread(DoWorkSimple);
		t0.Start();
		
		// Create a new thread using the ThreadStart delegate
		Thread t1 = new Thread(new ThreadStart(DoWorkSimple));
		t1.Start();

		// Create a new thread using the ParameterizedThreadStart delegate
		Thread t2 = new Thread(new ParameterizedThreadStart(DoWorkWithParameter));
		t2.Start("parameter");

		// Create a new thread with a custom stack size
		Thread t3 = new Thread(new ThreadStart(DoWorkSimple), 1024 * 1024); // 1 MB stack size
		t3.Start();

		// Create a new thread with a name
		Thread t4 = new Thread(new ThreadStart(DoWorkSimple));
		t4.Name = "Named Thread";
		t4.Start();

		// Create new thread that call parameterized
		Thread t5 = new Thread( () => DoWorkWithParameter("parameter2"));
		t5.Start();

		// Create new thread that call parameterized
		Thread t6 = new Thread(DoWorkWithParameter);
		t6.Start("parameter3");
	}

	static void DoWorkSimple()
	{
		Console.WriteLine("Simple work: Thread ID={0}", Thread.CurrentThread.ManagedThreadId);
	}

	static void DoWorkWithParameter(object param)
	{
		Console.WriteLine("Parameterized work: Thread ID={0}, Parameter='{1}'", Thread.CurrentThread.ManagedThreadId, param);
	}
}
