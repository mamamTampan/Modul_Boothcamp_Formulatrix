using System;
using System.Collections.Generic;

namespace HashSetDemo
{
    class Program
    {
        static void Main()
        {
            // Creating a HashSet to store car brands
            HashSet<string> carBrands = new HashSet<string>();

            // Adding elements to the HashSet using Add method
            carBrands.Add("Honda");
            carBrands.Add("Toyota");
            carBrands.Add("Ford");
            carBrands.Add("Nissan");

            // Adding duplicate elements does not throw an error, but they are ignored
            carBrands.Add("Honda");
            carBrands.Add("Toyota");

            // Count property returns the number of unique elements in the HashSet
            Console.WriteLine($"Number of elements in the HashSet: {carBrands.Count}");

            // Accessing elements in the HashSet using foreach loop
            Console.WriteLine("\nElements in the HashSet:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }

            // Contains method checks if a specified element is present in the HashSet
            Console.WriteLine($"\nDoes the HashSet contain 'Honda'? {carBrands.Contains("Honda")}");
            Console.WriteLine($"Does the HashSet contain 'BMW'? {carBrands.Contains("BMW")}");

            // Remove method removes the specified element from the HashSet
            carBrands.Remove("Ford");
            Console.WriteLine($"\nAfter removing 'Ford', elements in the HashSet:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }

            // Clear method removes all elements from the HashSet
            carBrands.Clear();
            Console.WriteLine("\nAfter clearing the HashSet, number of elements: " + carBrands.Count);

            // AddRange method adds elements from another collection to the HashSet
            List<string> moreCarBrands = new List<string>() { "Hyundai", "Kia", "Chevrolet" };
            carBrands.UnionWith(moreCarBrands);
            Console.WriteLine("\nAfter adding elements from a list, elements in the HashSet:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }

            // CopyTo method copies the elements of the HashSet to an array
            string[] carArray = new string[carBrands.Count];
            carBrands.CopyTo(carArray);
            Console.WriteLine("\nAfter copying elements to an array, elements in the array:");
            foreach (string car in carArray)
            {
                Console.WriteLine(car);
            }

            // IsSubsetOf method checks if the HashSet is a subset of another collection
            HashSet<string> allCarBrands = new HashSet<string>() { "Honda", "Toyota", "Ford", "Nissan", "Hyundai", "Kia", "Chevrolet" };
            Console.WriteLine($"\nIs the HashSet a subset of all car brands? {carBrands.IsSubsetOf(allCarBrands)}");

            // IsSupersetOf method checks if the HashSet is a superset of another collection
            Console.WriteLine($"Is the HashSet a superset of all car brands? {carBrands.IsSupersetOf(allCarBrands)}");

            // SetEquals method checks if the HashSet and another collection have the same elements
            HashSet<string> anotherHashSet = new HashSet<string>() { "Nissan", "Ford", "Toyota", "Hyundai", "Chevrolet", "Kia" };
            Console.WriteLine($"Do the HashSet and another HashSet have the same elements? {carBrands.SetEquals(anotherHashSet)}");
        }
    }
}
