
using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
            }

            if (nights > 7 && (month == "May" || month == "October"))
            {
                studio *= 0.95;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doubleRoom *= 0.9;
            }
            else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suite *= 0.85;
            }

            double studioPrice = studio * nights;
            double doublePrice = doubleRoom * nights;
            double suitePrice = suite * nights;

            if (nights > 7 && (month == "September" || month == "October"))
            {
                studioPrice = studio * (nights - 1);
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}