namespace Namespace
{
	static class Program
	{
		static void Main()
		{
			double a = 4.0;
			double b = 2.5;
			List<double> list = new List<double>();
			double answer = Add(a, b);
			
			list.Add(a);
			list.Add(b);
			list.Add(answer);

			Console.WriteLine($"{a} + {b} = {answer}");
			
			foreach(double x in list)
			{
				Console.WriteLine(x);
			}
			string y = Console.ReadLine();
			Console.WriteLine(y);
		}
		static double Add(double a, double b)
		{
			return a + b;
		}
	}
}