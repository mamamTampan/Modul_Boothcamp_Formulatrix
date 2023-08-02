class Program
{
	static void Main(string[] args)
	{
		Parent objA = new Parent("Parent");
		FirstChild objB = new FirstChild("FirstChild");
		SecondChild objC = new SecondChild("SecondChild");

		Console.WriteLine(objB.name);

		Console.WriteLine(objA.PrintOut()); //classA PrintOut method called
		Console.WriteLine(objB.PrintOut());
		Console.WriteLine(objC.PrintOut());
	}
}

class Parent
{ //PARENT
	public string? name;
	public Parent(string name)
	{
		Console.WriteLine("Parent constructor called :" + name);
		this.name = name;
	}
	public Parent() 
	{
	}
	public virtual string PrintOut()
	{
		return ("Parent PrintOut method called");
	}

}

class FirstChild : Parent
{
	public FirstChild(string name) : base(name)
	{
		Console.WriteLine("FirstChild constructor called :" + name);
	}
	//Error because parent class does not have a default constructor
	/* public classB() {
		Console.WriteLine("classB constructor called without passing argument");
	} */
}

class SecondChild : Parent
{
	public SecondChild(string name) : base(name)
	{
		Console.WriteLine("SecondChild constructor called :" + name);
	}

	public override string PrintOut()
	{
		return ("SecondChild PrintOut method called");
	}
}