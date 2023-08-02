public class MyClass
{
    public int value;

    public MyClass(int value)
    {
        this.value = value;
    }

    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.value + b.value);
    }
}

class Program
{
    static void Main()
    {
        MyClass myClassX = new MyClass(10);
        MyClass myClassY = new MyClass(20);
        MyClass myClassZ = new MyClass(25);
        MyClass result = myClassX + myClassY + myClassZ;
        Console.WriteLine(result.value); // Output: "55"
    }
}
