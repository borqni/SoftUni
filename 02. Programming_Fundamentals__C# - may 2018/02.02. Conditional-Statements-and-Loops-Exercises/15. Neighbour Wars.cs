using System;

namespace _2.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int demagePesho = int.Parse(Console.ReadLine());
            int demageGosho = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int round = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (healthGosho - demagePesho <= 0)
                    {
                        round++;
                        Console.WriteLine($"Pesho won in {round}th round.");
                        return;
                    }
                    else
                    {
                        round++;
                        healthGosho -= demagePesho;
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }
                }
                else if (i % 2 != 0)
                {
                    if (healthPesho - demageGosho <= 0)
                    {
                        round++;
                        Console.WriteLine($"Gosho won in {round}th round.");
                        return;
                    }
                    else
                    {
                        round++;
                        healthPesho -= demageGosho;
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }
                }
                
                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        }
    }
}