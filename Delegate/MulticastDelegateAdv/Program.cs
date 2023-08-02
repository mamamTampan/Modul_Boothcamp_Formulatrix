public delegate void MyEventHandler(object sender, EventArgs e);

public class MyClass
{
    private MyEventHandler _myEventHandlers;

    public event MyEventHandler MyEvent
    {
        add
        {
            _myEventHandlers += value;
        }
        remove
        {
            _myEventHandlers -= value;
        }
    }

    public void TriggerEvent()
    {
        EventArgs e = EventArgs.Empty;
        _myEventHandlers?.Invoke(this, e);
    }
}

public class Program
{
    public static void Main()
    {
        MyClass myObject = new MyClass();
        myObject.MyEvent += MyEventHandler1;
        myObject.MyEvent += MyEventHandler2;

        myObject.TriggerEvent();
    }

    private static void MyEventHandler1(object sender, EventArgs e)
    {
        Console.WriteLine("MyEventHandler1 called by " + sender.ToString());
    }

    private static void MyEventHandler2(object sender, EventArgs e)
    {
        Console.WriteLine("MyEventHandler2 called by " + sender.ToString());
    }
}
