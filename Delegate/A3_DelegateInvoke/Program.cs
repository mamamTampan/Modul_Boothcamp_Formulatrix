public delegate void Delegate(string message);
public class Publisher
{
	public Delegate MyEvent;

	public void DoSomething()
	{
		Console.WriteLine("Doing something interesting...");
		OnMyEvent("Hello, World!");
	}

	protected virtual void OnMyEvent(string message)
	{
		MyEvent?.Invoke(message);
	}
}

public class Subscriber1
{
	public void MyEventHandler(string message)
	{
		Console.WriteLine($"MyEventHandler {message}");
	}
}

public class Subscriber2
{
	public void MyEventHandler(string message)
	{
		Console.WriteLine($"MyEventHandler {message}");
	}

	public void MyEventHandler2(string message)
	{
		Console.WriteLine($"MyEventHandler2 {message}");
	}
}

public class Program
{
	static void Main(string[] args)
	{
		Publisher publisher = new Publisher();
		Subscriber1 subscriber1 = new Subscriber1();
		Subscriber2 subscriber2 = new Subscriber2();
		
		publisher.MyEvent += subscriber1.MyEventHandler;
		publisher.MyEvent += subscriber2.MyEventHandler;
		publisher.DoSomething();
		//publisher.OnMyEvent("Hello, world!");
	}
}
