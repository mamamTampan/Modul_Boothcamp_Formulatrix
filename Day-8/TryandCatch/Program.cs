namespace TryandCatch;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			int[] numbers = { 1, 2, 3 };
			Console.WriteLine(numbers[5]);
		}
		catch (IndexOutOfRangeException e)
		{
			Console.WriteLine($"Oops, you went out of bounds {e.Message}!");
		}
	}
}
