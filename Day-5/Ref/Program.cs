
class Program
{
	static void Main()
	{
		int number = 10;
		
		int result = MultiplyByTwo(number);
		Console.WriteLine(result); 
		
		MultiplyByTwoRef(ref number);
		Console.WriteLine(number); 
	}
	static int MultiplyByTwo(int x) 
	{
		return x = x * 2;
	}
	static bool MultiplyByTwoRef(ref int x)
	{
		if (x>0)
		{
			x=x * 2;
			return true;
		}
		return false;
	}
}
