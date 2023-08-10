using System;
namespace ConstructorDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Cat alex = new Cat(); 
			alex.SetName("alex");
			Console.WriteLine(alex.GetName());
		}
	}

	public class Cat
	{
		private string? name;
		public int age { 
			get 
			{
				return age;
			}
			set
			{
				Console.WriteLine("Setting age");
				age = value;
				Console.WriteLine("Age set");
			}
		}
		
		public void SetName(string name)
		{
			this.name = name;
		}
		public string? GetName()
		{
			return name;
		}
	}
}