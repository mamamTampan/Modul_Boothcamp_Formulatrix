using Object_as_Reference__Class_;

class Program 
{
	static void Main() 
	{
		MetalDoor carDoor = new("Olympic");
		HalogenLamp carLamp = new("Phillips");
		CombustionEngine carMachine = new("V6");

		WoodenDoor woodenDoor= new("");
		LedLamp ledLamp = new("");
		ElectricEngine electricEngine= new("");
		
		Car car = new(carDoor, carLamp, carMachine);
		Car car1 = new(woodenDoor, LedLamp, ElectricEngine);
	}
}