using System;

namespace OperatorOverloadingExample
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int newNumerator = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
            int newDenominator = f1.Denominator * f2.Denominator;

            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int newNumerator = (f1.Numerator * f2.Denominator) - (f2.Numerator * f1.Denominator);
            int newDenominator = f1.Denominator * f2.Denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Fraction sum = f1 + f2;
            Fraction difference = f1 - f2;

            Console.WriteLine($"f1: {f1}");
            Console.WriteLine($"f2: {f2}");
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"difference: {difference}");

            Console.ReadLine();
        }
    }
}
