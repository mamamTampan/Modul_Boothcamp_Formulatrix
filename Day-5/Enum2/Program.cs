namespace TrialProgram;

static class Program
{
	static void Main()
	{
		enumDays day1 = enumDays.Monday;
		Console.WriteLine(day1); // output:
		Console.WriteLine((int)day1);  // output:

		string userDays = "Monday";
		enumDays day = (enumDays)Enum.Parse(typeof(enumDays), userDays);
		Console.WriteLine("Parsed enum value : " + day);
		Console.WriteLine("Parsed enum value : " + (int)day);
	}
}

public enum enumDays
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}