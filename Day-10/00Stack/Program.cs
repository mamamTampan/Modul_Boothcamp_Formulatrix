using System;
using System.Collections;

namespace StackCollectionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Creating a stack collection
			Stack stack = new Stack();

			// Adding item to the stack using the push method
			stack.Push(10);
			stack.Push("Hello");
			stack.Push(3.14f);
			stack.Push(true);
			stack.Push(67.8);
			stack.Push('A');

			// Printing the original stack items using foreach loop
			Console.WriteLine("Original stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}

			// Removing an item from the stack
			Console.WriteLine("\nRemoving an item from the stack:");
			stack.Pop();
			Console.WriteLine("New stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}

			// Removing all items from the stack
			Console.WriteLine("\nRemoving all items from the stack:");
			stack.Clear();
			Console.WriteLine("New stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}

			// Adding item to the stack using the push method
			stack.Push("C#");
			stack.Push(42);
			stack.Push("World");

			// Printing the new stack items using foreach loop
			Console.WriteLine("\nNew stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}

			// Checking if an item is in the stack
			Console.WriteLine("\nChecking if an item is in the stack:");
			bool containsCSharp = stack.Contains("C#");
			bool containsPython = stack.Contains("Python");
			Console.WriteLine("Contains C#: " + containsCSharp);
			Console.WriteLine("Contains Python: " + containsPython);

			// Cloning the stack
			Console.WriteLine("\nCloning the stack:");
			Stack clonedStack = (Stack)stack.Clone();
			Stack clonedStack2 = stack;
			Console.WriteLine("Original stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Cloned stack:");
			foreach (object item in clonedStack)
			{
				Console.WriteLine(item);
			}

			// Copying the stack to an array
			Console.WriteLine("\nCopying the stack to an array:");
			object[] stackArray = new object[stack.Count];
			stack.CopyTo(stackArray, 0);
			Console.WriteLine("Stack array:");
			foreach (object item in stackArray)
			{
				Console.WriteLine(item);
			}

			// Peeking at the top item in the stack
			Console.WriteLine("\nPeeking at the top item in the stack:");
			object topItem = stack.Peek();
			Console.WriteLine("Top item: " + topItem);

			Console.ReadKey();
		}
	}
}
