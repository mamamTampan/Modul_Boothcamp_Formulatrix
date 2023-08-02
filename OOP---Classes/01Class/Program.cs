using System;
using CalculatorLib;

namespace ClassObjectsDemo
{
	class Program
	{
		static void Main()
		{
			Calculator calObject = new Calculator();

			int result = calObject.CalculateSum(10, 20);

			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}