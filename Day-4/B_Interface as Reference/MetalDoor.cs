using B_Interface_as_Reference;
namespace Object_as_Reference__Class_;

public class MetalDoor : IDoor
{
	public string doorBrand;
	public MetalDoor (string doorBrand) 
	{
		this.doorBrand = doorBrand;
	}
	public void Handle() 
	{
		Console.WriteLine("Open Handle");
	}
}
