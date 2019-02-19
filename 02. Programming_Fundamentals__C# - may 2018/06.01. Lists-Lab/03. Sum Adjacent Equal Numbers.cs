using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<decimal> input = Console.ReadLine()
            .Split()
            .Select(decimal.Parse)
            .ToList();

        int i = 0;

        while (i < input.Count - 1)
        {
            if (input[i] == input[i + 1])
            {
                input[i] += input[i + 1];
                input.RemoveAt(i + 1);
                i--;
                if (i < 0)
                {
                    i = 0;
                }
            }
            else
            {
                i++;
            }
        }

        Console.WriteLine(string.Join(" ", input));
    }
}