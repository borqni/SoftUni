using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;

            while ("Bake!" != input)
            {
                count++;
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}