using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "cheese")
                {
                    calories += 500;
                }
                else if (input == "tomato sauce")
                {
                    calories += 150;
                }
                else if (input == "salami")
                {
                    calories += 600;
                }
                else if (input == "pepper")
                {
                    calories += 50;
                }
                else
                {
                    calories += 0;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}