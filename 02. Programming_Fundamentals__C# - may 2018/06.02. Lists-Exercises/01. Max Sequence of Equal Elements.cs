using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // 3 4 4 5 5 5 2 2
            int counter = 1;
            int bestNumber = 0;
            int bestCount = 0;

            if (numbers.Count <= 1)
            {
                Console.WriteLine(numbers.First());
                return;
            }

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestNumber = numbers[i];
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestNumber + " ");
            }
        }
    }
}