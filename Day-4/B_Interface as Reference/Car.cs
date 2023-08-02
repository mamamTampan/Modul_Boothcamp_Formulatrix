using B_Interface_as_Reference;

namespace Object_as_Reference__Class_;

public class Car 
{
	public IDoor door;
	public ILamp lamp;
	public IEngine machine;

	public Car(IDoor door, ILamp lamp,IEngine machine) 
	{
		this.door = door;
		this.lamp = lamp;
		this.machine = machine;
	}
}
