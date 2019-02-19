using System;
using System.Collections.Generic;
using System.Linq;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombIndex = numbers.IndexOf(bombs[0]);

            while (bombIndex >= 0)
            {
                int leftBombIndex = bombIndex - bombs[1];
                if (leftBombIndex < 0)
                {
                    leftBombIndex = 0;
                }

                int rightBombIndex = bombIndex + bombs[1];
                if (rightBombIndex > numbers.Count - 1)
                {
                    rightBombIndex = numbers.Count - 1;
                }

                numbers.RemoveRange(leftBombIndex, rightBombIndex - leftBombIndex + 1);
                bombIndex = numbers.IndexOf(bombs[0]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}