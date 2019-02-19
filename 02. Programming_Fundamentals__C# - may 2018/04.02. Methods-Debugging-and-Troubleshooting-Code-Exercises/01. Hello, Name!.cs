using System;

namespace ChooseADrink_01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        static void PrintName()
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}