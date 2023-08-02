using System;

public class MyEventPublisher
{
    public delegate void MyDelegate(object sender, MyEventArgs e);
    public MyDelegate MyEvent;

    public void DoSomething()
    {
        Console.WriteLine("Doing something interesting...");
        OnMyEvent("Hello, World!");
    }

    protected virtual void OnMyEvent(string message)
    {
        MyEvent?.Invoke(this, new MyEventArgs(message));
    }
}

public class MyEventArgs : EventArgs
{
    public string Message { get; }

    public MyEventArgs(string message)
    {
        Message = message;
    }
}

public class MyEventSubscriber1
{
    public void MyEventHandler(object sender, MyEventArgs e)
    {
        Console.WriteLine($"B1_Event handled by subscriber 1. Message: {e.Message}");
    }
}

public class MyEventSubscriber2
{
    public void MyEventHandler(object sender, MyEventArgs e)
    {
        Console.WriteLine($"B1_Event handled by subscriber 2. Message: {e.Message}");
    }

    public void MyEventHandler2(object sender, MyEventArgs e)
    {
        Console.WriteLine($"B1_Event handled 2 by subscriber 2. Message: {e.Message}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var publisher = new MyEventPublisher();
        var subscriber1 = new MyEventSubscriber1();
        var subscriber2 = new MyEventSubscriber2();
        publisher.MyEvent += subscriber1.MyEventHandler;
        publisher.MyEvent += subscriber2.MyEventHandler;
        publisher.DoSomething();
    }
}
