using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
}
   
public class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        Point p3 = p1 + p2; // p3 is now a Point with X=4 and Y=6
        Console.WriteLine($"p3.X = {p3.X}, p3.Y = {p3.Y}");
    }
}
