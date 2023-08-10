using System;

class Program {
	delegate void SimpleDelegate();

	static void Main(string[] args) {
		SimpleDelegate helloDelegate = PrintHello;
		SimpleDelegate worldDelegate = PrintWorld;

		SimpleDelegate multicastDelegate = helloDelegate + worldDelegate;
		
		multicastDelegate();
	}

	static void PrintHello() {
		Console.WriteLine("Hello,");
	}

	static void PrintWorld() {
		Console.WriteLine("World!");
	}
}
