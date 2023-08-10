class Program
{
	static void Main()
	{
		try
		{
			int a = 10, b = 0;
			try
			{
				int c = a / b;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("inside trycatch "+ex.Message);
			}
			finally
			{
				Console.WriteLine("inside finally");
				//int c = a/b;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("outside trycatch "+ex.Message);
		}

	}
}