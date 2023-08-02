namespace TypeBasics
{
    public class Car
    {
        public string Brand;
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        public void Start()
        {
            Console.WriteLine($"Starting the {Brand} {Model}...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla", 2022, "Blue");

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Brand} {myCar.Model} in {myCar.Color} color.");
            myCar.Start();
        }
    }
}