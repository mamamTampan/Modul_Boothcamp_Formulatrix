using System;
using System.Collections;

namespace SortedListCollectionDemo
{
    class Program
    {
        static void Main()
        {
            //Creating a SortedList collection to store car brands
            SortedList<string, int> carBrands = new SortedList<string, int>();

            //Adding elements to the carBrands SortedList using the Add method
            carBrands.Add("Honda", 1);
            carBrands.Add("Toyota", 2);

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

            //Adding the car brands from different collections to the "carBrands" SortedList using the AddRange method
            foreach (string brand in moreCarBrands)
            {
                carBrands.Add(brand, carBrands.Count + 1);
            }

            foreach (string brand in stackCarBrands)
            {
                carBrands.Add(brand, carBrands.Count + 1);
            }

            foreach (string brand in queueCarBrands)
            {
                carBrands.Add(brand, carBrands.Count + 1);
            }

            //Accessing individual car brands and their positions in the "carBrands" SortedList
            Console.WriteLine("Car Brands and Their Positions:");
            Console.WriteLine($"Honda: {carBrands["Honda"]}");
            Console.WriteLine($"Toyota: {carBrands["Toyota"]}");
            Console.WriteLine($"Ford: {carBrands["Ford"]}");
            Console.WriteLine($"Chevrolet: {carBrands["Chevrolet"]}");
            Console.WriteLine($"BMW: {carBrands["BMW"]}");
            Console.WriteLine($"Mercedes: {carBrands["Mercedes"]}");
            Console.WriteLine($"Nissan: {carBrands["Nissan"]}");
            Console.WriteLine($"Mazda: {carBrands["Mazda"]}");

            //Removing a specific car brand from the "carBrands" SortedList using the Remove method
            var removedItem = carBrands.Remove("Honda");
            Console.WriteLine($"\nRemoved item: {removedItem}");

            //Removing all car brands from the "carBrands" SortedList that have positions greater than 4
            for (int i = carBrands.Count - 1; i >= 0; i--)
            {
                if (carBrands.Values[i] > 4)
                {
                    carBrands.RemoveAt(i);
                }
            }

            //Sorting the "carBrands" SortedList by their positions using the default comparer
            carBrands = new SortedList<string, int>(carBrands, Comparer<string>.Default);

            //Reversing the order of the elements in the "carBrands" SortedList
            carBrands.Reverse();

            Console.ReadKey();
        }
    }
}
