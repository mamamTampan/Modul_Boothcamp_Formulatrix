using System;

public struct MyStruct
{
	public int number;
	public int[] array;
}

public class Program
{
	static void Main()
	{
		MyStruct myStruct = new MyStruct();
		myStruct.number = 0;
		myStruct.array = new int[] { 1, 2, 3 };

		MyStruct myStruct1 = myStruct;
		myStruct1.number = 1;
		myStruct1.array = new int[] { 2, 2, 2 };

		Console.WriteLine(myStruct.number);       // Output: 
		Console.WriteLine(myStruct.array[0]);     // Output: 
		Console.WriteLine(myStruct1.number);      // Output: 
		Console.WriteLine(myStruct1.array[0]);    // Output: 

		myStruct1.array = myStruct.array;
		myStruct1.array = new int[] { 3, 3, 3 };  
		Console.WriteLine(myStruct.array[0]);     //Output :
		Console.WriteLine(myStruct1.array[0]);	  //Output :
	}
}
