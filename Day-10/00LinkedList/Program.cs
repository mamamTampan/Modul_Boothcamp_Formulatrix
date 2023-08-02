using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new LinkedList with string elements
        LinkedList<string> myLinkedList = new LinkedList<string>();

        // Add some values to the linked list using the AddLast method
        myLinkedList.AddLast("Apple");
        myLinkedList.AddLast("Banana");
        myLinkedList.AddLast("Cherry");

        // Insert a new element at the beginning of the linked list using the AddFirst method
        myLinkedList.AddFirst("Apricot");

        // Insert a new element at a specific index using the AddBefore method
        LinkedListNode<string> node = myLinkedList.Find("Banana");
        myLinkedList.AddBefore(node, "Avocado");

        // Insert a new elem ent at the end of the linked list using the AddLast method
        myLinkedList.AddLast("Date");

        // Print out the contents of the linked list using a foreach loop
        foreach (string element in myLinkedList)
        {
            Console.WriteLine(element);
        }

        // Remove the first element from the linked list using the RemoveFirst method
        myLinkedList.RemoveFirst();

        // Remove the last element from the linked list using the RemoveLast method
        myLinkedList.RemoveLast();

        // Remove a specific element from the linked list using the Remove method
        myLinkedList.Remove("Cherry");

        // Print out the contents of the linked list using a foreach loop
        Console.WriteLine("\nLinked List After Removals:");
        foreach (string element in myLinkedList)
        {
            Console.WriteLine(element);
        }

        // Clear the linked list using the Clear method
        myLinkedList.Clear();

        Console.ReadLine();
    }
}
