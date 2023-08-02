class ChildOfChild : Child 
{
	public ChildOfChild() 
	{
		Console.WriteLine("Constructor of ChildOfChild");
	}
	~ChildOfChild() 
	{
		Console.WriteLine("Destructor of ChildOfChild");
	}
}
class Child : Parent 
{
	public Child() 
	{
		Console.WriteLine("Constructor of Child");
	}
	~Child() 
	{
		Console.WriteLine("Destructor of Child");
	}
}
class Parent 
{
	public Parent() 
	{
		Console.WriteLine("Constructor of Parent");
	}
	~Parent() 
	{
		Console.WriteLine("Destructor of Parent");
	}
}

class Program 
{
	static void Main() 
	{
		ChildofChildCreator();
		ParentCreator();
	}
	static void ChildofChildCreator() 
	{
		ChildOfChild myChild = new ChildOfChild();
	}
	static void ParentCreator() 
	{
		Parent parent= new Parent();
	}
}