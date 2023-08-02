public interface IPrint
{
	void Print();
}

public interface IScan
{
	void Scan();
}
public interface IFax
{
	void Fax();
}

public class DefaultPrinter : IPrint, IScan
{
	public DefaultPrinter()
	{
		Console.WriteLine("Constructor Printer");
	}
	public void Print()
	{
		Console.WriteLine("DefaultPrinter Printing...");
	}
	public void Scan()
	{
		Console.WriteLine("DefaultPrinter Scan...");
	}
	public virtual void Fax()
	{
		Console.WriteLine("DefaultPrinter Fax..");
	}
}
public class Printer3Juta : DefaultPrinter, IPrint, IScan, IFax
{
	public Printer3Juta()
	{
		Console.WriteLine("Constructor Printer3Juta");
	}
	public new void Print()
	{
		Console.WriteLine("Printer3Juta Print");
	}
	public new void Scan()
	{
		Console.WriteLine("Printer3Juta Scan");
	}
	public override void Fax()
	{
		Console.WriteLine("Printer3Juta Fax..");
	}
}

