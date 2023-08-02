using System;

public class MyClass
{
	public int number;
	public int[] array;
}

public class Program
{
	static void Main()
	{
		MyClass myClass = new MyClass();
		myClass.number = 0;
		myClass.array = new int[] { 1, 2, 3 };

		MyClass myClass1 = myClass;
		myClass1.number = 1;
		myClass1.array = new int[] { 2, 2, 2 };

		Console.WriteLine(myClass.number);       // Output: 
		Console.WriteLine(myClass.array[0]);     // Output: 
		Console.WriteLine(myClass1.number);      // Output: 
		Console.WriteLine(myClass1.array[0]);    // Output: 

		myClass1.array = myClass.array;
		myClass1.array = new int[] { 3, 3, 3 };  
		Console.WriteLine(myClass.array[0]);     //Output : 
		Console.WriteLine(myClass1.array[0]);	  //Output : 
	}
}
