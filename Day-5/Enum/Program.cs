using System;

public class Program
{
	public enum DaysOfWeek
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}

	public static void Main()
	{
		foreach (var day in Enum.GetValues(typeof(DaysOfWeek)))
		{
			Console.WriteLine(day);
		}
	}
}
