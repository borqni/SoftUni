using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
        SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

        foreach (var num in input)
        {
            if (!numbers.ContainsKey(num))
            {
                numbers.Add(num, 0);
            }

            numbers[num]++;
        }

        foreach (var num in numbers)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}