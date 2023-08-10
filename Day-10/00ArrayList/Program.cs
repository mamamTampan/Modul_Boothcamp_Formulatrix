using System;
using System.Collections;

class Program {
	static void Main(string[] args) {
		ArrayList myArrayList = new();

		// Adding elements to the ArrayList
		myArrayList.Add("Apple");
		myArrayList.Add("Banana");
		myArrayList.Add("Cherry");
		myArrayList.Add("Durian");

		// Accessing elements in the ArrayList
		Console.WriteLine("Element at index 1: " + myArrayList[1]);
		Console.WriteLine("Element at index 3: " + myArrayList[3]);

		// Displaying all elements in the ArrayList
		Console.WriteLine("All elements:");
		foreach (string fruit in myArrayList) {
			Console.WriteLine(fruit);
		}
	}
}
