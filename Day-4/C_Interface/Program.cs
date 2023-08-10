using System.Numerics;
using C_Interface;

class Program
{
	static void Main() 
	{
		AeroPlane plane = new AeroPlane();
		Car car= new Car();
		FutureCar futureCar = new FutureCar();
		
		Dealer dealer= new Dealer(car,futureCar,futureCar,futureCar);
		
	}
}