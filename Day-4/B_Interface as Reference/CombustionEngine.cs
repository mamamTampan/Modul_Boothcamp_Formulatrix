using B_Interface_as_Reference;
namespace Object_as_Reference__Class_;

public class CombustionEngine : IEngine
{
	public string machinePiston;
	public CombustionEngine(string machinePiston)
	{
		this.machinePiston = machinePiston;
	}
	public void EngineOn() 
	{
		Console.WriteLine("Engine On");
	}
}
