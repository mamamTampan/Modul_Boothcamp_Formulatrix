using System;

namespace GarbageCollection
{
	class Program
	{
		static void ShortLives(Car parent)
		{
			Car toyota = new Car
			{
				Brand = "Toyota",
				CarChildOne = new Car { Brand = "Lexus" }
			};

			parent.CarChildTwo = toyota.CarChildOne;
		}

		static void CreateCar()
		{
			Car honda = new Car
			{
				Brand = "Honda",
				CarChildOne = new Car { Brand = "Acura" }
			};

			ShortLives(honda);

			Console.WriteLine("Leaving 'ShortLives'...");

			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		static void Main()
		{
			CreateCar();

			Console.WriteLine("\nLeaving 'Run'...");

			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	public class Car
	{
		public string Brand { get; set; }
		public Car CarChildOne { get; set; }
		public Car CarChildTwo { get; set; }

		~Car()
		{
			Console.WriteLine($"   Collecting {Brand}.");
		}
	}
}


