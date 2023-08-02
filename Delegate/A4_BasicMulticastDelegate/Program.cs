public delegate void MyDelegate(string message);

public class MyClass
{
    public void MethodA(string message)
    {
        Console.WriteLine("MethodA: " + message);
    }

    public void MethodB(string message)
    {
        Console.WriteLine("MethodB: " + message);
    }
}

public class Program
{
    public static void Main()
    {
        MyClass myObject = new MyClass();
        MyDelegate myDelegate = myObject.MethodA;
        myDelegate += myObject.MethodB;

        myDelegate.Invoke("Hello, world!");
    }
}
