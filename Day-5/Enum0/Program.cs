using System;

public class Program
{
	public enum DaysOfWeek
	{
		Monday ,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}

	public static void Main()
	{
		DaysOfWeek today = DaysOfWeek.Monday;

		Console.WriteLine("Today is: " + today);
		
		switch (today)
		{
			case DaysOfWeek.Sunday:
				Console.WriteLine("Sunday");
				break;
			case DaysOfWeek.Monday:
				Console.WriteLine(DaysOfWeek.Monday);
				break;
			case DaysOfWeek.Tuesday:
				Console.WriteLine("Tuesday");
				break;
		}
	}
}
