using System.Collections;

class Program {
	static void Main(string[] args) {
		ArrayList myArrayList = new ArrayList();

		// Adding elements to the ArrayList
		myArrayList.Add("Apple");
		myArrayList.Add("Banana");
		myArrayList.Add("Cherry");
		myArrayList.Add("Durian");
		//myArrayList.Add(123123123); error message
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		
		// Sorting the ArrayList
		myArrayList.Sort();
		
		// Inserting an element at a specific index
		myArrayList.Insert(2, "Elderberry");
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");

		// Accessing elements in the ArrayList
		Console.WriteLine("Element at index 1: " + myArrayList[1]);
		Console.WriteLine("Element at index 3: " + myArrayList[3]);

		// Removing an element from the ArrayList
		myArrayList.Remove("Banana");
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		
		// Removing all elements from the ArrayList
		myArrayList.Clear();
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		myArrayList.Add("MyFruit");
		Console.WriteLine("-------");
		
		// Checking if an element is in the ArrayList
		bool containsDurian = myArrayList.Contains("Durian");
		Console.WriteLine("Does the ArrayList contain Durian? " + containsDurian);
		
		// Cloning the ArrayList
		ArrayList myArrayListClone = (ArrayList)myArrayList.Clone();
		ArrayList myArrayListClone2 = myArrayListClone;
		// Copying elements from the ArrayList to an array
		string[] myArray = new string[myArrayList.Count];
		myArrayList.CopyTo(myArray);
		foreach(var element in myArray) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		


		// Displaying all elements in the ArrayList
		Console.WriteLine("All elements in myArrayListClone:");
		foreach (string fruit in myArrayListClone) {
			Console.WriteLine(fruit);
		}
	}
}
