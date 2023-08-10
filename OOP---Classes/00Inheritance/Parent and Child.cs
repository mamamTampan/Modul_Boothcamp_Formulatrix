namespace InheritanceTutorial;
class Parent
{
	public string? myString;
	public Parent(string myString)
	{
		myString = "Parent";
	}
		public Parent()
	{
		myString = "Parent";
	}
	public void MyMethodParent()
	{
		Console.WriteLine("Parent.MyMethodParent");
	}
}

class Child : Parent
{
	public string? myStringx;
	public Child(string y) : base(y)
	{
		myString = y;
	}
	public void MyMethodChild()
	{
		Console.WriteLine("Child.MyMethodChild");
	}
}

