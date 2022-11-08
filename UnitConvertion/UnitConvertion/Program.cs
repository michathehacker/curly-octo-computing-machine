using System;

namespace UnitConvertion
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("1-Convertion of Kg to Grams");
            Console.WriteLine("2-Convertion of Grams to Kg");
            Console.WriteLine("3-Convertion of Meters to Miles");
            Console.WriteLine("4-Convertion of Miles to Meters");
            Console.WriteLine("5-Convertion of Liters to Miligrams");
            Console.WriteLine("6-Convertion of Miligrams to Liters ");

            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("Enter the amount of Kg:");
                double amountOfKG = Double.Parse(Console.ReadLine());
                double amountOfGrams = amountOfKG * 1000;
                Console.WriteLine(amountOfKG + "kg = " + amountOfGrams + "g");
            }

            if (choose == 2)
            {
                Console.WriteLine("Enter the amount of Grams:");
                double Grams = Double.Parse(Console.ReadLine());
                double Kgs = Grams / 1000;
                Console.WriteLine(Grams + "g = " + Kgs + "kg");
            }

            if (choose == 3)
            {
                Console.WriteLine("Enter the amount of Meters:");
                double Meters = Double.Parse(Console.ReadLine());
                double Miles = Meters / 1600;
                Console.WriteLine(Meters + "m = " + Miles + "mi");
            }

            if (choose == 4)
            {
                Console.WriteLine("Enter the amount of Miles:");
                double miles = Double.Parse(Console.ReadLine());
                double meters = miles * 1600;
                Console.WriteLine(miles + "mi = " + meters + "m");
            }
            
            if(choose == 5)
            {
                Console.WriteLine("Enter the amount of Liters:");
                double liters = Double.Parse(Console.ReadLine());
                double miligrams = liters * 1000;
                Console.WriteLine(liters + "L = " + miligrams + "ml");
            }

            if (choose == 6)
            {
                Console.WriteLine("Enter the amount of Miligrams:");
                double mls = Double.Parse(Console.ReadLine());
                double Ls = mls / 1000;
                Console.WriteLine(mls + "ml = " + Ls + "L");
            }

        }
    }
}
