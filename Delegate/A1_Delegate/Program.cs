namespace DelegateTutorial;

public delegate int MyDelegate(int a, int b);
class Program {
	static void Main() {
		MyDelegate operation = new MyDelegate(Program.Add);
		int add = operation(2, 3);
		Console.WriteLine(add);

		operation = Program.Multiply;
		int multiply = operation(2, 3);
		Console.WriteLine(multiply);
	}

	public static int Add(int a, int b) {
		return a + b;
	}

	public static int Multiply(int a, int b) {
		return a * b;
	}
}
