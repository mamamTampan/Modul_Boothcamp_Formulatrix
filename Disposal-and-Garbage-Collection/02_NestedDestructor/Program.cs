class CompositonClass
{
	public CompositonClass()
	{
		Console.WriteLine("CompositonClass created");
	}
	~CompositonClass()
	{
		Console.WriteLine("CompositonClass destructor called.");
	}
}

class MainClass
{
	CompositonClass otherObj = new CompositonClass();
	public MainClass()
	{
		Console.WriteLine("MainClass created");
	}
	~MainClass()
	{
		Console.WriteLine("MainClass destructor called.");
	}
}

class Program
{
	static void Main(string[] args)
	{
		GenerateClass();

		GC.Collect();
		GC.WaitForPendingFinalizers();
	}

	static void GenerateClass()
	{
		MainClass myObj = new MainClass();
	}
}

