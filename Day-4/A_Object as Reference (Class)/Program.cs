using Object_as_Reference__Class_;

class Program 
{
	static void Main() 
	{
		Door carDoor = new("Olympic");
		Lamp carLamp = new("Phillips");
		Machine carMachine = new("V6");

		Car car = new(carDoor, carLamp, carMachine);
	}
}