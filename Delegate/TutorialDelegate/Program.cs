using System;

class Program {
    delegate void SimpleDelegate();

    static void Main(string[] args) {
        SimpleDelegate myDelegate = PrintHello;
        myDelegate += PrintWorld;
        myDelegate = myDelegate + PrintWorld;
        myDelegate();
    }

    static void PrintHello() {
        Console.WriteLine("Hello, delegate!");
    }
    static void PrintWorld() {
        Console.WriteLine("World!");
    }
}
