using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double totalEnergy = (volume * energy) / 100.0;
            double totalSugar = (volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}