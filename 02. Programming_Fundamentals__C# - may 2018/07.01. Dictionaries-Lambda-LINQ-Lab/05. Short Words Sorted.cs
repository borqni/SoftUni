using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> elements = Console.ReadLine()
            .ToLower()
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .Select(x => x)
            .Where(x => x.Length < 5)
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(", ", elements));
    }
}