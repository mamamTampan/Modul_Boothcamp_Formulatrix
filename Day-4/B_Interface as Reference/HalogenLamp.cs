using B_Interface_as_Reference;
namespace Object_as_Reference__Class_;

public class HalogenLamp : ILamp
{
	public string lamp;
	public HalogenLamp(string lamp) 
	{
		this.lamp = lamp;
	}
	public void LampOn() 
	{
		Console.WriteLine("Lamp On");
	}
}
