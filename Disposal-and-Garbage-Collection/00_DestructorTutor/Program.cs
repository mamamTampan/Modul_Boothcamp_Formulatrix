
class Program 
{
	static void Main() 
	{
		CreateObject();
		
		GC.Collect();	
		GC.WaitForPendingFinalizers();
	}
	static void CreateObject()
	{
		Player player= new Player("Player1");

		CreateMoreObject();
		
	}
	static void CreateMoreObject() 
	{
		Player player = new Player("Player2");
		Player player2 = new Player("Player3");
	}
}

class Player{
	public string myString;
	public Player(string myString)
	{
		this.myString = myString;
		Console.WriteLine("Constructed " + myString);
	}
	~Player()
	{
		Console.WriteLine("Deconstructed " + myString);
	}
}