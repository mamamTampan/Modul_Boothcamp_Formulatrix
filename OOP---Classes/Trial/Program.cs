class Program 
{
	static void Main() 
	{
		Printer3Juta child = new Printer3Juta();
		DefaultPrinter parent = child;
		
		child.Print(); //new
		parent.Print();

		child.Scan(); //new
		parent.Scan();
		
		child.Fax(); //override
		parent.Fax();
	}
}