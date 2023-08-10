using System;

class Shape
{
    public void Display()
    {
        Console.WriteLine("Shape");
    }
}

class Circle : Shape
{
    public new void Display()
    {
        Console.WriteLine("Circle");
    }
}

class Program
{
    static void Main()
    {
        Shape shape = new Shape();
        shape.Display(); // Output: Shape

        Circle circle = new Circle();
        circle.Display(); // Output: Circle

        Shape shape2 = new Circle();
        shape2.Display(); // Output: Shape 
    }
}
