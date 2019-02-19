using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            int difference = int.Parse(Console.ReadLine());
            int countOfPairs = 0;

            foreach (int number in arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (number - difference == arr[i])
                    {
                        countOfPairs++;
                    }
                }
            }

            Console.WriteLine(countOfPairs);
        }
    }
}