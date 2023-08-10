
class Program 
{
	static void Main() 
	{
		int a = 100;
		double b = a;

		double c = 1000;
		int d = (int) c;
		
		Parent parent= new Parent();
		Child child = new Child();

		parent.MethodParentB();
		parent.MethodParentA();
		
		child.MethodParentB();
		child.MethodParentA();
		child.MethodChildA();
		child.MethodChildB();

		Parent parent2 = child;
		parent2.MethodParentB();
		parent2.MethodParentA();
		//parent2.MethodChildA();
		//parent2.MethodChildB();
		
		Child child1 = (Child) parent;
		child1.MethodParentB();
		child1.MethodParentA();
		child1.MethodChildB();
		child1.MethodChildA();
	}
}

public class Parent
{
	public void MethodParentA() 
	{
		Console.WriteLine("Method Parent A");
	}
	public void MethodParentB() 
	{
		Console.WriteLine("Method Parent B");
	}
}
public class Child : Parent
{
	public void MethodChildA() 
	{
		Console.WriteLine("Method Child A");
	}
	public void MethodChildB() 
	{
		Console.WriteLine("Method Child B");
	}
}