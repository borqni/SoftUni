using System;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int priceHall = 0;
            int pricePackage = 0;
            double discount = 0;
            string hallName = "";

            if (groupSize <= 50)
            {
                priceHall = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                priceHall = 5000;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                priceHall = 7500;
                hallName = "Great Hall";
            }
            else if (groupSize > 121)
            {
                priceHall = 0;
            }

            if (package == "Normal")
            {
                pricePackage = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                pricePackage = 750;
                discount = 0.10;
            }
            else if (package == "Platinum")
            {
                pricePackage = 1000;
                discount = 0.15;
            }

            int totalPrice = priceHall + pricePackage;
            double discountPrice = totalPrice - (totalPrice * discount);
            double price = discountPrice / groupSize;

            if (priceHall < 1)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:F2}$ ");
            }
        }
    }
}