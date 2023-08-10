class Program
{
	static void Main()
	{
		ToyBox<int> intGenericClass = new ToyBox<int>(10);
		int result = intGenericClass.ToyBoxMethod(5);
		Console.WriteLine($"Nilai Mainan: {result}");

		ToyBox<string> stringGenericClass = new ToyBox<string>("Hello");
		stringGenericClass.ToyBoxMethod("World");
		Console.WriteLine($"Nilai Mainan: {result}");
	}
}