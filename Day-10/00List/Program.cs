using System;
using System.Collections.Generic;

namespace GenericListCollectionDemo
{
    class Program
    {
        static void Main()
        {
            //Creating a Generic List of string type to store car brands
            List<string> carBrands = new List<string>();

            //Adding elements to the carBrands list using the Add method
            carBrands.Add("Honda");
            carBrands.Add("Toyota");

            //Creating a new array of car brands
            string[] moreCarBrands = { "Ford", "Chevrolet" };

            //Creating a new Stack of car brands
            Stack<string> stackCarBrands = new Stack<string>();
            stackCarBrands.Push("BMW");
            stackCarBrands.Push("Mercedes");

            //Creating a new Queue of car brands
            Queue<string> queueCarBrands = new Queue<string>();
            queueCarBrands.Enqueue("Nissan");
            queueCarBrands.Enqueue("Mazda");

            //Adding the car brands from different collections to the "carBrands" list using the AddRange method
            carBrands.AddRange(moreCarBrands);
            carBrands.AddRange(stackCarBrands);
            carBrands.AddRange(queueCarBrands);

            //Inserting a new element at a specific position
            carBrands.Insert(2, "Audi");

            //Checking if an element is present in the list using the Contains method
            var isPresent = carBrands.Contains("Toyota");
            Console.WriteLine($"Is Toyota present in the list? {isPresent}");

            //Removing an element from the list using the Remove method
            var removedItem = carBrands.Remove("Honda");
            Console.WriteLine($"\nRemoved item: {removedItem}");

            //Removing all the elements that match a condition using the RemoveAll method
            var removedAll = carBrands.RemoveAll(c => c.StartsWith("M"));
            Console.WriteLine($"\nNumber of items removed: {removedAll}");

            //Clearing the entire list using the Clear method
            //carBrands.Clear();

            //Copying the elements of the list to an array using the CopyTo method
            string[] carBrandsArray = new string[carBrands.Count];
            carBrands.CopyTo(carBrandsArray);

            //Finding the first element that matches a condition using the Find method
            var firstMatch = carBrands.Find(c => c.StartsWith("F"));
            Console.WriteLine($"\nFirst match: {firstMatch}");

            //Finding all the elements that match a condition using the FindAll method
            var allMatches = carBrands.FindAll(c => c.StartsWith("B"));
            Console.WriteLine("\nAll matches:");
            foreach (var match in allMatches)
            {
                Console.WriteLine(match);
            }

            //Finding the last element that matches a condition using the FindLast method
            var lastMatch = carBrands.FindLast(c => c.StartsWith("N"));
            Console.WriteLine($"\nLast match: {lastMatch}");

            //Sorting the list using the Sort method
            carBrands.Sort();

            //Reversing the order of the elements in the list using the Reverse method
            carBrands.Reverse();

            //Accessing the car brands in the "carBrands" list using foreach loop
            Console.WriteLine("\nCar Brands:");
            foreach (var carBrand in carBrands)
            {
                Console.WriteLine(carBrand);
            }

            Console.ReadKey();
        }
    }
}
