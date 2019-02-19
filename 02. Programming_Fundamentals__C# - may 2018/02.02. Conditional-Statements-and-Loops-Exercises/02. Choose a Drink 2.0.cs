using System;

namespace ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantity * 1;
                    break;
                case "SoftUni Student":
                    totalPrice = quantity * 1.7;
                    break;
                default:
                    totalPrice = quantity * 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}