using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int curentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int curentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: |" + new string('|', curentHealth) + new string('.', maxHealth - curentHealth) + "|");
            Console.WriteLine($"Energy: |{new string('|', curentEnergy)}" + $"{new string('.', maxEnergy - curentEnergy)}|");
        }
    }
}