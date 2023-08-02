using System;
namespace DestructorExample
{
	class DestructorDemo
	{
		private string name;
		public DestructorDemo(string name)
		{
			this.name = name;
			Console.WriteLine($"Constructor {name} Object Created");
		}
		~DestructorDemo()
		{
			Console.WriteLine($"Object {name} is Destroyed");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ObjectCreator();

			GC.Collect();
			GC.WaitForPendingFinalizers();

		}
		static void ObjectCreator()
		{
			DestructorDemo obj1 = new DestructorDemo("obj1");
			DestructorDemo obj2 = new DestructorDemo("obj2");
		}
	}
}