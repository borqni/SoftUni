using System;
using System.Linq;

namespace MostFrequentNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = new int[numbers.Max() + 1];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        result[numbers[i]]++;
                    }
                }
            }

            int maxValue = result.Max();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (result[numbers[i]] == maxValue)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
            }
        }
    }
}