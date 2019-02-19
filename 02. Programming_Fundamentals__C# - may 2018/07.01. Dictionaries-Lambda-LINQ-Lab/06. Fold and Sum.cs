using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] elements = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int k = elements.Length / 4;

        int[] firstElement = elements.Take(k).Reverse().ToArray();
        int[] lastElement = elements.Reverse().Take(k).ToArray();
        firstElement = firstElement.Concat(lastElement).ToArray();
        int[] midleElement = elements.Skip(k).Take(k * 2).ToArray();

        Console.WriteLine(string.Join(" ", midleElement.Select((key, val) => key += firstElement[val])));
    }
}