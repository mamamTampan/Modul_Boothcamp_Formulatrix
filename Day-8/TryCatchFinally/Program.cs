using System;

class Program 
{
	static void Main(string[] args) 
	{
		try 
		{
			// Code that may throw an exception
			int a = 10, b = 0;
			int c = a / b;
		}
		catch (DivideByZeroException endException) 
		{
			// Code to handle the exception
			Console.WriteLine("An error occurred: {0}", endException.ToString());
		}
		finally 
		{
			// Code that will always be executed, regardless of whether an exception was thrown or not
			Console.WriteLine("Finally.");
		}
		Console.WriteLine("The program has finished executing.");
	}
} 
