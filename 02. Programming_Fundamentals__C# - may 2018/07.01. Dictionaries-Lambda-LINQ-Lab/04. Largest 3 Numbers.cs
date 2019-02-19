using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();

        Console.WriteLine(string.Join(" ", number));
    }
}