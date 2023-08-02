using InheritanceTutorial;

static class Program {
	static void Main() {
		Parent parent = new Parent("k");
		Child child = new Child("n");

		Console.WriteLine(parent.myString);
		Console.WriteLine(child.myString);
		parent.MyMethodParent();

		child.MyMethodParent();
		child.MyMethodChild();
	}
}