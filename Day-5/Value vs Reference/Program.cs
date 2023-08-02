class Program
{
	static void Main() 
	{
		int a = 10;
		int b = a;
		b = 11;
		Console.WriteLine(a); //10
		Console.WriteLine(b); //11 

		MyClass myClassA = new(3, 4);
		MyClass myClassB = myClassA;
		myClassB.y = 5;
		Console.WriteLine($"\nMyClassA {myClassA.x} , {myClassA.y}"); //3,5
		Console.WriteLine($"MyClassB {myClassB.x} , {myClassB.y}"); //3,5


		int[] intArrA = { 1, 2, 3 };
		int[] intArrB = intArrA;
		intArrB[0] = 4;
		Console.WriteLine("\nintArrA = ");
		foreach(int x in intArrA) //4,2,3
		{
			Console.Write(x + ", ");
		}
		Console.WriteLine("\nnintArrB = "); //4,2,3
		foreach(int x in intArrB) 
		{
			Console.Write(x + ", ");
		}
	}
}
class MyClass 
{
	public int x;
	public int y;
	public MyClass(int a, int b) 
	{
		x = a;
		y = b;
	}
}
