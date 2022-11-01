using System;

namespace UnitConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertion of Kg to Grams");
            Console.WriteLine("Enter the amount of Kg:");
            double amountOfKG = Double.Parse(Console.ReadLine());
            double amountOfGrams = amountOfKG * 1000;
            Console.WriteLine( amountOfKG + "kg = " + amountOfGrams + "g");

            Console.WriteLine("Convertion of Grams to Kg");
            Console.WriteLine("Enter the amount of Grams:");
            double Grams = Double.Parse(Console.ReadLine());
            double Kgs = Grams / 1000;
            Console.WriteLine(Grams + "g = " + Kgs + "kg");

            Console.WriteLine("Convertion of Meters to Miles");
            Console.WriteLine("Enter the amount of Meters:");
            double Meters = Double.Parse(Console.ReadLine());
            double Miles = Meters / 1600;
            Console.WriteLine(Meters + "m = " + Miles + "mi");

            Console.WriteLine("Convertion of Miles to Meters");
            Console.WriteLine("Enter the amount of Miles:");
            double miles = Double.Parse(Console.ReadLine());
            double meters = miles * 1600;
            Console.WriteLine(miles + "mi = " + meters + "m");



        }
    }
}
